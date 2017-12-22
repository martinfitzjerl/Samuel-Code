using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Mvc.Models;

namespace WebApp.Mvc.Controllers
{
    public class BananaController : Controller//can do web stuff
    {
        // GET: Banana
        [HttpGet]
        public ActionResult Index()
        {
            if (ModelState.IsValid) ;
            var p = new Person() { GivenName = "sam" };
            ViewBag.Data = "nan";//dynamic object
            ViewData["DATA"] = "huh"; //based on dictionary, string object, ViewData and ViewBag from action to view that is the only time it will survive
            TempData["DATA"] = "one"; //tempdata will survive a redirect, until final response it returned
            Session["DATA"] = "hav"; //will survive past redirect

            return RedirectToAction("Default");
            return View(p);//overloaded method but in its basic form it will find the index, convention over configuration
        }

        [HttpPost]
        [HttpGet]
        //[CustomValidation]//wants the ID in the format we want it to be
        //[CustomException]//
        [Authorize]//I need to know the user before you can enter here
                   //we have to create our own exception filters because there are so many
        public ActionResult Default()
        {
            var p = new Person() { GivenName = "class" };
            return View("Index", p);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//make sure same session has the form, make sure browser is the same that has form and sends it out
        public ActionResult Validate(Person p) //validation server side for the bad people
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }

            return View("Failure");

        }
        [HttpGet]
        public ActionResult Success()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Failure()//we want to see our failure before we submit
        {
            return View();
        }

    }
}