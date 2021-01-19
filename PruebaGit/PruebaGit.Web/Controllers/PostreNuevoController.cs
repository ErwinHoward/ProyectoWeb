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
    public class PostreNuevoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PostreNuevo
        public ActionResult Index()
        {
            return View(db.PostreNuevo.ToList());
        }

        // GET: PostreNuevo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostreNuevo PostreNuevo = db.PostreNuevo.Include(a => a.Administradors).Where(a => a.Id == id).SingleOrDefault();

            if (PostreNuevo == null)
            {
                return HttpNotFound();
            }
            return View(PostreNuevo);
        }

        // GET: PostreNuevo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostreNuevo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre")] PostreNuevo postrenuevo)
        {
            if (ModelState.IsValid)
            {
                db.PostreNuevo.Add(postrenuevo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(postrenuevo);
        }

        // GET: PostreNuevo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostreNuevo PostreNuevo = db.PostreNuevo.Find(id);
            if (PostreNuevo == null)
            {
                return HttpNotFound();
            }
            return View(PostreNuevo);
        }

        // POST: PostreNuevo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre")] PostreNuevo PostreNuevo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(PostreNuevo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(PostreNuevo);
        }

        // GET: PostreNuevo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PostreNuevo PostreNuevo = db.PostreNuevo.Find(id);
            if (PostreNuevo == null)
            {
                return HttpNotFound();
            }
            return View(PostreNuevo);
        }

        // POST: PostreNuevo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PostreNuevo PostreNuevo = db.PostreNuevo.Find(id);
            db.PostreNuevo.Remove(PostreNuevo);
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
