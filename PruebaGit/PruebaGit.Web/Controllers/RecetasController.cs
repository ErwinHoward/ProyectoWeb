using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PruebaGit.Web.Models;

namespace PruebaGit.Web.Controllers
{
    public class RecetasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Recetas
        public ActionResult Index()
        {
            return View(db.recetasBases.ToList());
        }

        // GET: Recetas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recetasBase recetasBase = db.recetasBases.Find(id);
            if (recetasBase == null)
            {
                return HttpNotFound();
            }
            return View(recetasBase);
        }

        // GET: Recetas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recetas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Ingredientes,Cantidad")] recetasBase recetasBase)
        {
            if (ModelState.IsValid)
            {
                db.recetasBases.Add(recetasBase);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recetasBase);
        }

        // GET: Recetas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recetasBase recetasBase = db.recetasBases.Find(id);
            if (recetasBase == null)
            {
                return HttpNotFound();
            }
            return View(recetasBase);
        }

        // POST: Recetas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Ingredientes,Cantidad")] recetasBase recetasBase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recetasBase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recetasBase);
        }

        // GET: Recetas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recetasBase recetasBase = db.recetasBases.Find(id);
            if (recetasBase == null)
            {
                return HttpNotFound();
            }
            return View(recetasBase);
        }

        // POST: Recetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            recetasBase recetasBase = db.recetasBases.Find(id);
            db.recetasBases.Remove(recetasBase);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
