using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageRepository());
        public IActionResult InBox()
        {
            int id = 3;
            var values = mm.GetInboxByWriter(id).OrderBy(x => x.MessageDate).ToList();
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var values = mm.GetById(id);         
            return View(values);
        }
    }
}
