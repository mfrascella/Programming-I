using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectAladdinASCIIWebArt.Models;

namespace ProjectAladdinASCIIWebArt.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //starting point
        public ActionResult Index()
        {
            return View();
        }

        //looks at user input and determines which picture will be printed
        public ActionResult ChoosePic(string picChoice, int timesPrinted)
        {
            Pictures lotsOfPictures = new Pictures();
            ViewBag.timesPrinted = timesPrinted;

            if (picChoice == "Genie")
            {
                ViewBag.Pictures = lotsOfPictures.Genie();
            }
            else if (picChoice == "Abu")
            {
                ViewBag.Pictures = lotsOfPictures.Abu();
            }
            else
            {
                ViewBag.Pictures = lotsOfPictures.Rajah();
            }

            return View();
        }
    }
}

