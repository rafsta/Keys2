using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Keys2.Controllers
{
    public class ProductSoldsController : Controller
    {
        // GET: sales
        public ActionResult Index()
        {
            return View();
        }

        // GET: sales/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: sales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: sales/Create
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

        // GET: sales/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: sales/Edit/5
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

        // GET: sales/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: sales/Delete/5
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