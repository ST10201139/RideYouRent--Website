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
    public class Car_Body_TypeController : Controller
    {
        private The_Ride_You_Rent db = new The_Ride_You_Rent();

        // GET: Car_Body_Type
        public ActionResult Index()
        {
            return View(db.Car_Body_Type.ToList());
        }

        // GET: Car_Body_Type/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car_Body_Type car_Body_Type = db.Car_Body_Type.Find(id);
            if (car_Body_Type == null)
            {
                return HttpNotFound();
            }
            return View(car_Body_Type);
        }

        // GET: Car_Body_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Car_Body_Type/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BodyID,BodyType")] Car_Body_Type car_Body_Type)
        {
            if (ModelState.IsValid)
            {
                db.Car_Body_Type.Add(car_Body_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(car_Body_Type);
        }

        // GET: Car_Body_Type/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car_Body_Type car_Body_Type = db.Car_Body_Type.Find(id);
            if (car_Body_Type == null)
            {
                return HttpNotFound();
            }
            return View(car_Body_Type);
        }

        // POST: Car_Body_Type/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BodyID,BodyType")] Car_Body_Type car_Body_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car_Body_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car_Body_Type);
        }

        // GET: Car_Body_Type/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car_Body_Type car_Body_Type = db.Car_Body_Type.Find(id);
            if (car_Body_Type == null)
            {
                return HttpNotFound();
            }
            return View(car_Body_Type);
        }

        // POST: Car_Body_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car_Body_Type car_Body_Type = db.Car_Body_Type.Find(id);
            db.Car_Body_Type.Remove(car_Body_Type);
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
