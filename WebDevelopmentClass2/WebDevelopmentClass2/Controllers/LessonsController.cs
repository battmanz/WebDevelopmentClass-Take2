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

        public ActionResult MinMaxDemo()
        {
            return View();
        }

        public ActionResult CenteredContentDemo()
        {
            return View();
        }

        public ActionResult FixedPositioningDemo()
        {
            return View();
        }

        public ActionResult ClearFloatDemo()
        {
            return View();
        }
    }
}