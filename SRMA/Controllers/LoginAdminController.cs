﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SRMA.Controllers
{
    public class LoginAdminController : Controller
    {
        // GET: LoginAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginAdmin()
        {
            return RedirectToAction("Index", "LoginAdmin");
        }

        public ActionResult LoginAdminAccess()
        {
            return RedirectToAction("Admin", "Home");
        }

        // GET: LoginAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginAdmin/Create
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

        // GET: LoginAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginAdmin/Edit/5
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

        // GET: LoginAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginAdmin/Delete/5
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
