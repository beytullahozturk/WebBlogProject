using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWriter(WriterClass p)
        {
            writers.Add(p);
            var jsonWriter = JsonConvert.SerializeObject(p);
            return Json(jsonWriter);
        }
        public IActionResult DeleteWriter(int id)
        {
            var findwriter = writers.FirstOrDefault(x => x.Id == id);
            writers.Remove(findwriter);
            return Json(findwriter);
        }
        public IActionResult UpdateWriter(WriterClass p)
        {
            var findwriter = writers.FirstOrDefault(x => x.Id == p.Id);
            findwriter.Id = p.Id;
            findwriter.Name = p.Name;
            var jsonwriter = JsonConvert.SerializeObject(p);
            return Json(jsonwriter);
        }
        public IActionResult GetWriterByID(int writerid)
        {
            var findwriter = writers.FirstOrDefault(x => x.Id == writerid);
            var jsonwriter = JsonConvert.SerializeObject(findwriter);

            return Json(jsonwriter);
        }
        public IActionResult WriterList()
        {
            var jsonWriter = JsonConvert.SerializeObject(writers);
            return Json(jsonWriter);
        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id=1,
                Name="Beytullah Öztürk"
            },
            new WriterClass
            {
                Id=2,
                Name="Zübeyde Öztürk"
            },
            new WriterClass
            {
                Id=3,
                Name="Ahmet Öztürk"
            },
            new WriterClass
            {
                Id=4,
                Name="Zehra Öztürk"
            },
            new WriterClass
            {
                Id=5,
                Name="İbrahim Öztürk"
            }
        };
    }
}
