using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDevelopmentClass2.Controllers
{
    public class EchoController : Controller
    {
        // GET: Echo
        public ActionResult Index()
        {
            var formCollection = new FormCollection(Request.QueryString);
            return View(formCollection);
        }

        // POST: Echo
        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            return View(formCollection);
        }
    }
}