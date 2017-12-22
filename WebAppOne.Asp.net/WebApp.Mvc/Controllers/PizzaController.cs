using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.MVC;
using Microsoft.AspNetCore.Http;
using System.Web.Mvc;

namespace WebApp.Mvc.Controllers
{
    public class PizzaController : Controller
    {
        private static SuperModel _SM; new SuperModel();

        public PizzaController()
        {
            _SM = 
        }
        private static List<Pizza> pizzas = new List<Pizza>();

        // GET: Pizza
        public ActionResult Index()
        {
            var sm = new SuperModel();
            return View(sm.GetPizza);
        }

        // GET: Pizza/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pizza/Create
        public ActionResult Create(Pizza p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    throw new ArgumentException("this pizza eh no good!!");
                }
                
            }
            SM.Add(p);

            return RedirectToAction(nameof(Index));
        }

        // POST: Pizza/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pizza/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pizza/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pizza/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
