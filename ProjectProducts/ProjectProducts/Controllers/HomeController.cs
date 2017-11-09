using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectProducts.Models;


namespace ProjectProducts.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Products> aListOfProducts = new List<Products>();
            string[] items = System.IO.File.ReadAllLines(@"C:\Users\mfras\Documents\CISY 1113\Products.txt");
            int[] id = new int[items.Length];
            for (int index = 0; index < items.Length; index++)
            {
                string[] tokens = items[index].Split(',');
                int idn = Convert.ToInt32(tokens[0]);
                string itemName = tokens[1];
                string itemPrice = tokens[2];
                int suppId = Convert.ToInt32(tokens[3]);
                int catId = Convert.ToInt32(tokens[4]);

                Products aProduct = new Products(idn, itemName, itemPrice, suppId, catId);

                aListOfProducts.Add(aProduct);
                
                ViewBag.aListOfProducts = aListOfProducts;
            }

            int counter = 0;
            string storeProducts = "";
            while (counter < (items.Length - 1))
            {
                storeProducts += "<pre>" + aListOfProducts[counter] + "</pre>" + "<br />";
                counter += 1;
            }


            ViewBag.StoreProducts = storeProducts;

            return View();
        }
    }
}