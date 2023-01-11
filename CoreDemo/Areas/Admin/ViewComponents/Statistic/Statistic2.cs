using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.lastBlog = c.Blogs.OrderByDescending(x => x.BlogID).Select(x => x.BlogTitle).Take(1).FirstOrDefault();
            var blogid = c.Blogs.OrderByDescending(x => x.BlogID).Select(x => x.WriterID).Take(1).FirstOrDefault();
            ViewBag.writerName = c.Writers.Where(x => x.WriterID == blogid).Select(x => x.WriterName).FirstOrDefault();

            return View();
        }
    }
}
