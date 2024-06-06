using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using The_Ride_You_Rent1.Models;

namespace The_Ride_You_Rent1.Controllers
{
    public class Car_MakeController : Controller
    {
        private The_Ride_You_Rent db = new The_Ride_You_Rent();

        // GET: Car_Make
        public ActionResult Index()
        {
            return View(db.Car_Make.ToList());
        }

        // GET: Car_Make/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car_Make car_Make = db.Car_Make.Find(id);
            if (car_Make == null)
            {
                return HttpNotFound();
            }
            return View(car_Make);
        }

        // GET: Car_Make/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Car_Make/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MakeID,CarMake")] Car_Make car_Make)
        {
            if (ModelState.IsValid)
            {
                db.Car_Make.Add(car_Make);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(car_Make);
        }

        // GET: Car_Make/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car_Make car_Make = db.Car_Make.Find(id);
            if (car_Make == null)
            {
                return HttpNotFound();
            }
            return View(car_Make);
        }

        // POST: Car_Make/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MakeID,CarMake")] Car_Make car_Make)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car_Make).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car_Make);
        }

        // GET: Car_Make/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car_Make car_Make = db.Car_Make.Find(id);
            if (car_Make == null)
            {
                return HttpNotFound();
            }
            return View(car_Make);
        }

        // POST: Car_Make/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car_Make car_Make = db.Car_Make.Find(id);
            db.Car_Make.Remove(car_Make);
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
