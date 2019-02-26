using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetirementHome.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Lifestyle()
        {
            ViewBag.Message = "Your lifestyle page.";

            return View();
        }

        public ActionResult Service()
        {
            ViewBag.Message = "Your Service Page.";

            return View();
        }
        public ActionResult Area()
        {
            ViewBag.Message = "Area Attraction Page";

            return View();
        }
        public ActionResult Dining()
        {
            ViewBag.Message = "Dining Page";

            return View();
        }

        public ActionResult Wellness()
        {
            ViewBag.Message = "Wellness Page";

            return View();
        }

        public ActionResult Health()
        {
            ViewBag.Message = "Health Page";

            return View();
        }
        public ActionResult Gallery()
        {
            ViewBag.Message = "Gallery Page";

            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Location Page";

            return View();
        }


    }
}