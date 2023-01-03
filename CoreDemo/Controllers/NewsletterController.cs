using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class NewsletterController : Controller
    {
        NewsletterManager nm = new NewsletterManager(new EfNewsletterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(Newsletter n)
        {
            n.NewsletterStatus = true;
            nm.Add(n);
            return PartialView();
        }
    }
}
