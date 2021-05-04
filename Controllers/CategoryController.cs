using M0502.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M0502.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public FileStreamResult GetImage(int id = 1)
        {
            var context = new NorthwindEntities();
            int offset = 78;
            var bytes = context.Categories.Where(c => c.CategoryID == id).Select(c => c.Picture).FirstOrDefault();
            return File(new MemoryStream(bytes, offset, bytes.Length - offset), "image/jpeg");
        }
    }
}