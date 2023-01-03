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
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment c)
        {
            c.CommentDate = DateTime.Parse(DateTime.Now.ToString());
            c.CommentStatus = true;
            c.BlogID = 1;
            cm.Add(c);
            return PartialView();
        }

        public PartialViewResult PartialCommentListByBlog(int id)
        {
            var values = cm.GetAllById(id);
            return PartialView(values);

        }
    }
}