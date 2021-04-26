using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaAdminTemplate.Controllers
{
    public class RastreoController : Controller
    {
        // GET: Rastreo
        public ActionResult Index()
        {
            return View();
        }

        // GET: Rastreo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rastreo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rastreo/Create
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

        // GET: Rastreo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rastreo/Edit/5
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

        // GET: Rastreo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rastreo/Delete/5
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
