using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GoToHome()
        {
            return View("HomeView");
        }
    }
}