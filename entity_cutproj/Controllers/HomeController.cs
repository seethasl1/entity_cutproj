using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace entity_cutproj.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View("GotoHome","Home");
        }
        public ActionResult GotoHome()
        {

            return View("GotoHome");
        }
        
    }
}