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
    public class Registrar_HospitalsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Registrar_Hospitals
        public ActionResult Index()
        {
            var registrar_Hospitals = db.Registrar_Hospitals.Include(r => r.Hospital);
            return View(registrar_Hospitals.ToList());
        }

        // GET: Registrar_Hospitals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registrar_Hospital registrar_Hospital = db.Registrar_Hospitals.Find(id);
            if (registrar_Hospital == null)
            {
                return HttpNotFound();
            }
            return View(registrar_Hospital);
        }

        // GET: Registrar_Hospitals/Create
        public ActionResult Create()
        {
            ViewBag.HospitalId = new SelectList(db.Hospitals, "Id", "Id");
            return View();
        }

        // POST: Registrar_Hospitals/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomHospital,Estado,Ciudad,Colonia,Calle,Codigo_Postal,HospitalId")] Registrar_Hospital registrar_Hospital)
        {
            if (ModelState.IsValid)
            {
                db.Registrar_Hospitals.Add(registrar_Hospital);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HospitalId = new SelectList(db.Hospitals, "Id", "Id", registrar_Hospital.HospitalId);
            return View(registrar_Hospital);
        }

        // GET: Registrar_Hospitals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registrar_Hospital registrar_Hospital = db.Registrar_Hospitals.Find(id);
            if (registrar_Hospital == null)
            {
                return HttpNotFound();
            }
            ViewBag.HospitalId = new SelectList(db.Hospitals, "Id", "Id", registrar_Hospital.HospitalId);
            return View(registrar_Hospital);
        }

        // POST: Registrar_Hospitals/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomHospital,Estado,Ciudad,Colonia,Calle,Codigo_Postal,HospitalId")] Registrar_Hospital registrar_Hospital)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registrar_Hospital).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HospitalId = new SelectList(db.Hospitals, "Id", "Id", registrar_Hospital.HospitalId);
            return View(registrar_Hospital);
        }

        // GET: Registrar_Hospitals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Registrar_Hospital registrar_Hospital = db.Registrar_Hospitals.Find(id);
            if (registrar_Hospital == null)
            {
                return HttpNotFound();
            }
            return View(registrar_Hospital);
        }

        // POST: Registrar_Hospitals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Registrar_Hospital registrar_Hospital = db.Registrar_Hospitals.Find(id);
            db.Registrar_Hospitals.Remove(registrar_Hospital);
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
