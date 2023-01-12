using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            string weatherKey = "ac430d1f7fc4d5810ff8fee478dc8943";
            string weatherCon = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + weatherKey;
            XDocument weatherDoc = XDocument.Load(weatherCon);
            ViewBag.heat = weatherDoc.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.description = weatherDoc.Descendants("clouds").ElementAt(0).Attribute("name").Value;

            ViewBag.blogCount = bm.GetAll().Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.commentCount = c.Comments.Count();
            return View();
        }
    }
}
