using Mul_Result.Dal;
using Mul_Result.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mul_Result.Controllers
{
    public class ProductController : Controller
    {

        ProductContext context;
        public ProductController()
        {
            context = new ProductContext();
        }
        [HttpGet]
        public ActionResult GetProducts()
        {
            List<Product> plist = context.Products.ToList();
            return View(plist); // ViewResult - class object
        }

        public ActionResult GetProductsData()
        {
            List<Product> plist = context.Products.ToList();

            return Json(plist, JsonRequestBehavior.AllowGet); // JsonResult - class object
        }
    }
}