using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoLibraryFinal.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult AdminView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminView(FormCollection collection)
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Users ="admin")]
        public ActionResult Payments()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}