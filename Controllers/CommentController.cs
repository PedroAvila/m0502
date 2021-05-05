using M0502.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M0502.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            var comment = new Comment()
            {
                Subject = "Buen producto",
                HtmlSubject = "El producto es <i>muy bueno</i> y el precio es <i>Excelente!!!</i>"
            };
            return View(comment);
        }

        [ChildActionOnly]
        public ActionResult _CommentList()
        {
            var vm = new ViewModelComments();
            var comments = vm.Comments.Take(5);
            return View(comments);
        }

        [ChildActionOnly]
        public ActionResult _CommentListById(int id)
        {
            var vm = new ViewModelComments();
            var comments = vm.Comments.Where(c => c.ID == id);
            return View("_CommentList", comments);
        }
    }
}