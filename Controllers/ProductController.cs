using M0502.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M0502.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display(int id)
        {
            var content = new NorthwindEntities();
            var product = content.Products.FirstOrDefault(p => p.ProductID == id);
            return View(product);
        }

        public ActionResult Create()
        {
            var product = new Product();
            return View(product);
        }

        [HttpPost]
        public ActionResult Create(Product newProduct)
        {
            ActionResult result = View(newProduct);
            if (ModelState.IsValid)
            {
                using (var context = new NorthwindEntities())
                {
                    context.Products.Add(newProduct);
                    context.SaveChanges();
                    result = RedirectToAction("Display", new { id = newProduct.ProductID });
                }
            }
            return result;
        }
    }
}