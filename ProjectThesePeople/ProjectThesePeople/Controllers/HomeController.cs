using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectThesePeople.Models;

namespace ProjectThesePeople.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Person person1 = new Person();
            person1.FirstName = "Maria";
            person1.LastName = "Frascella";
            person1.MiddleName = "Elizabeth";
            //person1.Id = 16;

            ViewBag.PersonList = person1;

            return View();
        }
    }
}