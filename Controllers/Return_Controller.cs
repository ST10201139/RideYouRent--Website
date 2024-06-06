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
    public class Return_Controller : Controller
    {
        private The_Ride_You_Rent db = new The_Ride_You_Rent();

        // GET: Return_
        public ActionResult Index()
        {
            var return_ = db.Return_.Include(r => r.Car).Include(r => r.Driver).Include(r => r.Inspector);
            return View(return_.ToList());
        }

        // GET: Return_/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Return_ return_ = db.Return_.Find(id);
            if (return_ == null)
            {
                return HttpNotFound();
            }
            return View(return_);
        }

        // GET: Return_/Create
        public ActionResult Create()
        {
            ViewBag.CarID = new SelectList(db.Cars, "CarID", "CarNumber");
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverID", "DriverName");
            ViewBag.InspectorNumber = new SelectList(db.Inspectors, "InspectorNumber", "InspectorName");
            return View();
        }

        // POST: Return_/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Return_id,CarID,InspectorNumber,DriverID,ReturnDate,ElapsedDate,Fine")] Return_ return_)
        {
            if (ModelState.IsValid)
            {
                db.Return_.Add(return_);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CarID = new SelectList(db.Cars, "CarID", "CarNumber", return_.CarID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverID", "DriverName", return_.DriverID);
            ViewBag.InspectorNumber = new SelectList(db.Inspectors, "InspectorNumber", "InspectorName", return_.InspectorNumber);
            return View(return_);
        }

        // GET: Return_/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Return_ return_ = db.Return_.Find(id);
            if (return_ == null)
            {
                return HttpNotFound();
            }
            ViewBag.CarID = new SelectList(db.Cars, "CarID", "CarNumber", return_.CarID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverID", "DriverName", return_.DriverID);
            ViewBag.InspectorNumber = new SelectList(db.Inspectors, "InspectorNumber", "InspectorName", return_.InspectorNumber);
            return View(return_);
        }

        // POST: Return_/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Return_id,CarID,InspectorNumber,DriverID,ReturnDate,ElapsedDate,Fine")] Return_ return_)
        {
            if (ModelState.IsValid)
            {
                db.Entry(return_).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CarID = new SelectList(db.Cars, "CarID", "CarNumber", return_.CarID);
            ViewBag.DriverID = new SelectList(db.Drivers, "DriverID", "DriverName", return_.DriverID);
            ViewBag.InspectorNumber = new SelectList(db.Inspectors, "InspectorNumber", "InspectorName", return_.InspectorNumber);
            return View(return_);
        }

        // GET: Return_/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Return_ return_ = db.Return_.Find(id);
            if (return_ == null)
            {
                return HttpNotFound();
            }
            return View(return_);
        }

        // POST: Return_/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Return_ return_ = db.Return_.Find(id);
            db.Return_.Remove(return_);
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
