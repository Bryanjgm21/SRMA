using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRMA.Controllers
{
    public class AdminReservationController : Controller
    {
        // GET: AdminReservation
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminReservation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminReservation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminReservation/Create
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

        // GET: AdminReservation/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: AdminReservation/Edit/5
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

        // GET: AdminReservation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminReservation/Delete/5
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
