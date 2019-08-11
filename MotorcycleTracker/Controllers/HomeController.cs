using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MotorcycleTracker.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This application tracks store's Motorcycle Inventory.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please contact our team here.";

            return View();
        }
    }
}