﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Notification
{
    public class NotificationList:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetLast2Blog();
            return View(values);
        }
    }
}
