using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VeterinariaV5.Models;

namespace VeterinariaV5.Controllers
{
    public class DueniosController : Controller
    {
        private VeteriDBEntities1 db = new VeteriDBEntities1();

        // GET: Duenios
        public ActionResult Index()
        {
            return View(db.Duenio.ToList());
        }

        // GET: Duenios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duenio duenio = db.Duenio.Find(id);
            if (duenio == null)
            {
                return HttpNotFound();
            }
            return View(duenio);
        }

        // GET: Duenios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Duenios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Apellido1,Apellido2,Correo")] Duenio duenio)
        {
            if (ModelState.IsValid)
            {
                db.Duenio.Add(duenio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(duenio);
        }

        // GET: Duenios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duenio duenio = db.Duenio.Find(id);
            if (duenio == null)
            {
                return HttpNotFound();
            }
            return View(duenio);
        }

        // POST: Duenios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Apellido1,Apellido2,Correo")] Duenio duenio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(duenio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(duenio);
        }

        // GET: Duenios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Duenio duenio = db.Duenio.Find(id);
            if (duenio == null)
            {
                return HttpNotFound();
            }
            return View(duenio);
        }

        // POST: Duenios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Duenio duenio = db.Duenio.Find(id);
            db.Duenio.Remove(duenio);
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
