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
    public class AgregarActividads1Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AgregarActividads1
        public ActionResult Index()
        {
            var agregarActividads = db.AgregarActividads.Include(a => a.Actividad);
            return View(agregarActividads.ToList());
        }

        // GET: AgregarActividads1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgregarActividad agregarActividad = db.AgregarActividads.Find(id);
            if (agregarActividad == null)
            {
                return HttpNotFound();
            }
            return View(agregarActividad);
        }

        // GET: AgregarActividads1/Create
        public ActionResult Create()
        {
            ViewBag.ActividadId = new SelectList(db.Actividads, "Id", "Id");
            return View();
        }

        // POST: AgregarActividads1/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ID_Paciente,ID_Empleado,Fecha,Hora,Actividad_Realizar,ActividadId")] AgregarActividad agregarActividad)
        {
            if (ModelState.IsValid)
            {
                db.AgregarActividads.Add(agregarActividad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ActividadId = new SelectList(db.Actividads, "Id", "Id", agregarActividad.ActividadId);
            return View(agregarActividad);
        }

        // GET: AgregarActividads1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgregarActividad agregarActividad = db.AgregarActividads.Find(id);
            if (agregarActividad == null)
            {
                return HttpNotFound();
            }
            ViewBag.ActividadId = new SelectList(db.Actividads, "Id", "Id", agregarActividad.ActividadId);
            return View(agregarActividad);
        }

        // POST: AgregarActividads1/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ID_Paciente,ID_Empleado,Fecha,Hora,Actividad_Realizar,ActividadId")] AgregarActividad agregarActividad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agregarActividad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ActividadId = new SelectList(db.Actividads, "Id", "Id", agregarActividad.ActividadId);
            return View(agregarActividad);
        }

        // GET: AgregarActividads1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgregarActividad agregarActividad = db.AgregarActividads.Find(id);
            if (agregarActividad == null)
            {
                return HttpNotFound();
            }
            return View(agregarActividad);
        }

        // POST: AgregarActividads1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AgregarActividad agregarActividad = db.AgregarActividads.Find(id);
            db.AgregarActividads.Remove(agregarActividad);
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
