using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManageDoctors()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult pharmacy()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}