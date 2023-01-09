using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.TotalBlog = c.Blogs.Count().ToString();
            ViewBag.TotalBlogForUser = c.Blogs.Where(x => x.WriterID == 1).Count().ToString();
            ViewBag.TotalCategory = c.Categories.Count().ToString();
            return View();
        }
    }
}
