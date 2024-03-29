﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtAddon.Controllers
{
    public class visualizeController : Controller
    {
        // GET: visualize
        public ActionResult Index(string roomid)
        {
            if(roomid==null|| roomid==string.Empty)
            {
                return new HttpStatusCodeResult(404);
            }
            return View("viewer");
        }

        public ActionResult concept(string roomid)
        {
            if (roomid == null || roomid == string.Empty)
            {
                return new HttpStatusCodeResult(404);
            }
            return View("concept");
        }
        public ActionResult keywords(string roomid)
        {
            if (roomid == null || roomid == string.Empty)
            {
                return new HttpStatusCodeResult(404);
            }
            return View("keyword");
        }
        // GET: visualize/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: visualize/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: visualize/Create
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

        // GET: visualize/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: visualize/Edit/5
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

        // GET: visualize/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: visualize/Delete/5
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
