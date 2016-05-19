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
                new Person { Name = "Muhamad Iqbal", Country = "Depok" }
            };
            return View(_person);
        }
    }
}