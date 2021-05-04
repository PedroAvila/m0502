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

        public ActionResult UploadPhoto()
        {
            var category = new Category();
            return View(category);
        }

        [HttpPost]
        public ActionResult UploadPhoto2(Category newCategory, HttpPostedFileBase file)
        {
            ActionResult result = View(newCategory);

            if (file != null && file.ContentLength > 0)
            {
                result = File(file.InputStream, file.ContentType);
            }
            return result;
        }

        [HttpPost]
        public ActionResult UploadPhoto(Category newCategory, HttpPostedFileBase file)
        {
            ActionResult result = View(newCategory);

            if (Request.Files.Count > 0 && Request.Files[0].ContentLength > 0)
            {
                result = File(Request.Files[0].InputStream, Request.Files[0].ContentType);
            }
            return result;
        }
    }
}