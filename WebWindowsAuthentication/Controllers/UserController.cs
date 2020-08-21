using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebWindowsAuthentication.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.IsPost = false;
            ViewBag.UserIdentityName = User?.Identity?.Name;
            ViewBag.ContextUserIdentityName = HttpContext?.User?.Identity?.Name;

            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult IndexPost()
        {
            ViewBag.IsPost = true;
            ViewBag.UserIdentityName = User?.Identity?.Name;
            ViewBag.ContextUserIdentityName = HttpContext?.User?.Identity?.Name;

            return View();
        }
    }
}