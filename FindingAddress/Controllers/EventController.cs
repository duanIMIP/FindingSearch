using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindingAddress.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult SimpleClickEvent()
        {
            return View();
        }

        public ActionResult AccessingArgument()
        {
            return View();
        }

        public ActionResult GettingPropertiesWithEventHandle()
        {
            return View();
        }

        public ActionResult PIOClickEvent()
        {
            return View();
        }
    }
}