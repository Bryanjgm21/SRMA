using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRMA.Controllers
{
    public class aController : Controller
    {
        // GET: a
        public ActionResult Index()
        {
            return View();
        }

        // GET: a/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: a/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: a/Create
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

        // GET: a/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: a/Edit/5
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

        // GET: a/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: a/Delete/5
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
