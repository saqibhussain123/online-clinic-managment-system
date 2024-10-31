using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
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
        public ActionResult doctors()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult blog()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult lab()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult pharmacy()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult bussines()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Education()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}