using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRMA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {

            return View();
        }

        public ActionResult LoginAdmin()
        {

            return RedirectToAction("LoginAdmin", "Login");
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}