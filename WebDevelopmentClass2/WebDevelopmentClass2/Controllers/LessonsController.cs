using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDevelopmentClass2.Controllers
{
    public class LessonsController : Controller
    {
        // GET: Lessons
        public ActionResult Index(int id)
        {
            return View("Lesson" + id);
        }
    }
}