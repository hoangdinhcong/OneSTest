using OneSTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneSTest.Controllers
{
    public class HomeController : Controller
    {
        private DBCSSolutionTestEntities db = new DBCSSolutionTestEntities();
        public ActionResult Index(int? catId)
        {
            var categories = db.categories.ToList();//.Include(c => c.category2);
            var products = db.products.ToList();//.Include(p => p.category);
            
            if (catId != null)
            {
                products = (from p in db.products where (p.category_id == catId) select p).ToList();
            }

            ViewModelCategoryProduct cp = new ViewModelCategoryProduct();
            cp.categories = categories;
            cp.products = products;
            
            return View(cp);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}