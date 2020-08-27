using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
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
        public ActionResult ApplePie()
        {
            ViewBag.Message = "Your Applepie page.";
            return View();
        }
        public ActionResult PumpkinPie()
        {
            return View();
        }
        public ActionResult RhubarbPie()
        {
            return View();
        }
    }
}