using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.adminName = c.Admins.Where(x => x.AdminID == 1).Select(x => x.Name).FirstOrDefault();
            ViewBag.adminImage = c.Admins.Where(x => x.AdminID == 1).Select(x => x.Image).FirstOrDefault();
            ViewBag.adminDescription = c.Admins.Where(x => x.AdminID == 1).Select(x => x.Description).FirstOrDefault();
            ViewBag.adminMail = c.Admins.Where(x => x.AdminID == 1).Select(x => x.Email).FirstOrDefault();
            return View();
        }
    }
}
