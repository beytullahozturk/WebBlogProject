using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryModel> categorylist = new List<CategoryModel>();
            categorylist.Add(new CategoryModel
            {
                categoryname = "Teknoloji",
                categorycount = 5
            });
            categorylist.Add(new CategoryModel
            {
                categoryname = "Yazılım",
                categorycount = 12
            });
            categorylist.Add(new CategoryModel
            {
                categoryname = "Donanım",
                categorycount = 3
            });
            categorylist.Add(new CategoryModel
            {
                categoryname = "Oyun",
                categorycount = 9
            });
            
            return Json(new { jsonlist = categorylist });
        }
    }
}
