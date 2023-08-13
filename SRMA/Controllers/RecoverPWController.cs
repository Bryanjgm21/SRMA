using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRMA.Controllers
{
    public class RecoverPWController : Controller
    {
        // GET: RecoverPW
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RecoverPW()
        {
            return RedirectToAction("Index", "RecoverPW");
        }

        // GET: RecoverPW/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecoverPW/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecoverPW/Create
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

        // GET: RecoverPW/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecoverPW/Edit/5
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

        // GET: RecoverPW/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecoverPW/Delete/5
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
