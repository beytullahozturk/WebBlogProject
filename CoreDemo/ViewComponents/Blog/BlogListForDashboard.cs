using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Blog
{
    [AllowAnonymous]
    public class BlogListForDashboard : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {

            var values = bm.GetAllBlogWithCategory().OrderByDescending(x => x.BlogID).Take(5).ToList();
            return View(values);
        }
    }
}
