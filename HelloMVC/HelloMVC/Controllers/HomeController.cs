using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Person> _person = new List<Person>()
            {
                new Person { Name = "Muhamad Iqbal", Country = "Depok" },
                new Person { Name = "Devin Brandon", Country = "Bogor" },
                new Person { Name = "Alvin Julian", Country = "Tangerang" }
            };
            return View(_person);
        }
    }
}