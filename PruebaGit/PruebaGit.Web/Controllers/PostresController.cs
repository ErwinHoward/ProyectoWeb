using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaGit.Web.Controllers
{
    public class PostresController : Controller
    {
        // GET: Postres
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: Postres/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Postres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Postres/Create
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

        // GET: Postres/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Postres/Edit/5
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

        // GET: Postres/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Postres/Delete/5
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
