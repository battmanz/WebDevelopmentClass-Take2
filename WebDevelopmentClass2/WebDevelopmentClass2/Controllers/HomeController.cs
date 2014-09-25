using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDevelopmentClass2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Resources
        public ActionResult Resources()
        {
            return View();
        }

        // GET: Home/Contact
        public ActionResult Contact()
        {
            return View();
        }
    }
}