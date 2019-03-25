using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindingAddress.Controllers
{
    public class PlaceController : Controller
    {
        // GET: Place
        public ActionResult Service()
        {
            return View();
        }

        public ActionResult PlaceSearchPanigation()
        {
            return View();
        }
    }
}