﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Category
{
    public class CategoryListForDashboard:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = cm.GetAll();
            return View(values);
        }
    }
}
