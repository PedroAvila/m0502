using M0502.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M0502.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var vm = new ViewModelComments();
            var comments = vm.Comments.Take(5);
            return View(comments);
        }

        public ActionResult About()
        {
            return Content("(c) TI Capacitación 2014");
        }
    }
}