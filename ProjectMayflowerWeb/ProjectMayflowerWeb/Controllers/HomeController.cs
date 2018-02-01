using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectMayflowerWeb.Models;
using System.IO;

namespace ProjectMayflowerWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Person> aListOfPeople = new List<Person>();
            string[] names = System.IO.File.ReadAllLines(@"C:\Users\mfras\Downloads\Mayflower.csv");
            int[] id = new int[names.Length];
            for (int index = 1; index < names.Length; index++)
            {

                string[] tokens = names[index].Split(',');
                int idn = Convert.ToInt32(tokens[0]);
                string fname = tokens[1];
                string lname = tokens[2];
                string mInitial = tokens[3];
                Person aPerson = new Person(idn, fname, lname, mInitial);

                aListOfPeople.Add(aPerson);

            }

            int counter = 0;
            string people = "";
            while (counter < (names.Length - 1))
            {
                people += aListOfPeople[counter];
                counter += 1;
            }

            ViewBag.Names = people;
            return View();

        }
    }
}