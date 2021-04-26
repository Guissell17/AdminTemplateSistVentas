using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaAdminTemplate.Controllers
{
    public class TrabajadoresController : Controller
    {
        // GET: Trabajadores
        public ActionResult Index()
        {
            return View();
        }

        // GET: Trabajadores/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Trabajadores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trabajadores/Create
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

        // GET: Trabajadores/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Trabajadores/Edit/5
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

        // GET: Trabajadores/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Trabajadores/Delete/5
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
