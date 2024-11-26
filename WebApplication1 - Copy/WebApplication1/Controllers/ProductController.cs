using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Dal;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        ProductContext dal = null;


        public ProductController() : base()
        {
            dal = new ProductContext();
        }
        public ActionResult Index()
        {
            List<Product> plist = dal.products.ToList();
            return View(plist);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                dal.products.Add(p);
                dal.SaveChanges();
                List<Product> plist = dal.products.ToList();
                return View("index", plist);
            }
            return View("Create", p);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Product s= dal.products.Find(id);
            return View(s);
        }
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            if (ModelState.IsValid)
            {
                Product x = dal.products.Find(p.Id);
                x.ProductName = p.ProductName;
                x.Quantity = p.Quantity;
                x.Price = p.Price;
                dal.SaveChanges();
                List<Product>plist = dal.products.ToList();
                return View("Index", plist);
            }
            return View("Edit", p);
        }
        public ActionResult Delete(int id)
        {
            Product k = dal.products.Find(id);
            dal.products.Remove(k);
            dal.SaveChanges();
            List<Product>plist = dal.products.ToList();
            return View("index",plist);
        }
        public ActionResult Details(int id)
        {
            Product p = dal.products.Find(id);
            return View(p);
        }
    }


}