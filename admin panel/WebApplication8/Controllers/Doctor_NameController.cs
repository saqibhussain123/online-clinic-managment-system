using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class Doctor_NameController : Controller
    {
        private MedicalEntities db = new MedicalEntities();

        // GET: Doctor_Name
        public ActionResult Index()
        {
            return View(db.Doctor_Name.ToList());
        }

        // GET: Doctor_Name/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor_Name doctor_Name = db.Doctor_Name.Find(id);
            if (doctor_Name == null)
            {
                return HttpNotFound();
            }
            return View(doctor_Name);
        }

        // GET: Doctor_Name/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doctor_Name/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Doctor_Name1,Department")] Doctor_Name doctor_Name)
        {
            if (ModelState.IsValid)
            {
                db.Doctor_Name.Add(doctor_Name);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctor_Name);
        }

        // GET: Doctor_Name/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor_Name doctor_Name = db.Doctor_Name.Find(id);
            if (doctor_Name == null)
            {
                return HttpNotFound();
            }
            return View(doctor_Name);
        }

        // POST: Doctor_Name/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Doctor_Name1,Department")] Doctor_Name doctor_Name)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor_Name).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctor_Name);
        }

        // GET: Doctor_Name/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor_Name doctor_Name = db.Doctor_Name.Find(id);
            if (doctor_Name == null)
            {
                return HttpNotFound();
            }
            return View(doctor_Name);
        }

        // POST: Doctor_Name/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doctor_Name doctor_Name = db.Doctor_Name.Find(id);
            db.Doctor_Name.Remove(doctor_Name);
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
