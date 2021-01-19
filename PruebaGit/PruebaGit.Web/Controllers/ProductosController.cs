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
    public class ProductosController : Controller
    {
        //Comunicacion entre clases 
        ProductosBL _bl = new ProductosBL();
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Productos
        public ActionResult Index()
        {

            return View(db.productosENs.ToList());
        }
        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        ///Pase de parametros de metodos/
        public ActionResult Agregar(ProductosEN pEN)
        {
            if (ModelState.IsValid)
            {
                db.productosENs.Add(pEN);
                db.SaveChanges();
            }
            return RedirectToAction("Index");


        }

        //METODO GET
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductosEN Id = db.productosENs.Find(id);
            if (Id == null)
            {
                return HttpNotFound();
            }
            return View(Id);
        }

        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductosEN Id = db.productosENs.Find(id);
            db.productosENs.Remove(Id);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductosEN productos = db.productosENs.Find(id);
            return View(productos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductosEN productos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productos);
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
     