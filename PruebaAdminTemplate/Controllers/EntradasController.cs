using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaAdminTemplate.Controllers
{
    public class EntradasController : Controller
    {
        // GET: Entradas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Entradas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Entradas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entradas/Create
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

        // GET: Entradas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Entradas/Edit/5
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

        // GET: Entradas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Entradas/Delete/5
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
