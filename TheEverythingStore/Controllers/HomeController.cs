using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheEverythingStore.Models;

namespace TheEverythingStore.Controllers
{
    public class HomeController : Controller
    {
        // connect to DB
        private DbModel db = new DbModel();

        public ActionResult Index()
        {
            return View();
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


        public ActionResult Products()
        {/* old untyped ViewBag code
            var products = new List<string>();

            //create mock products 
            for (int i = 1; i <= 10; i++) 
            {
                products.Add("Product " + i.ToString());
            }

            //pass mock products to the view for display
            ViewBag.Products = products; */

            //create 10 product objects
            //
           

            //use the product model to retrieve the entire product list from sql server
            var products = db.Products.ToList();

            // load the view and pass the product list to it
            return View(products);
        }

        //create a method that calls/generates the view
        public ActionResult ViewProduct(string ProductName)
        {

            ViewBag.ProductName = ProductName;
            return View();
        }

        
    }
}