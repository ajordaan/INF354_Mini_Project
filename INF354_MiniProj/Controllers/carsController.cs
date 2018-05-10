﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using INF354_MiniProj.Models;

namespace INF354_MiniProj.Controllers
{
    public class carsController : Controller
    {
        private furnatureEntities db = new furnatureEntities();

        // GET: cars
        public ActionResult Index()
        {
            var cars = db.cars.Include(c => c.car_type);
            return View(cars.ToList());
        }

        // GET: cars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            car car = db.cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: cars/Create
        public ActionResult Create()
        {
            ViewBag.car_type_id = new SelectList(db.car_type, "car_type_id", "car_type_description");
            return View();
        }

        // POST: cars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "car_id,car_make,car_model,car_type_id")] car car)
        {
            if (ModelState.IsValid)
            {
                db.cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.car_type_id = new SelectList(db.car_type, "car_type_id", "car_type_description", car.car_type_id);
            return View(car);
        }

        // GET: cars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            car car = db.cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            ViewBag.car_type_id = new SelectList(db.car_type, "car_type_id", "car_type_description", car.car_type_id);
            return View(car);
        }

        // POST: cars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "car_id,car_make,car_model,car_type_id")] car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.car_type_id = new SelectList(db.car_type, "car_type_id", "car_type_description", car.car_type_id);
            return View(car);
        }

        // GET: cars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            car car = db.cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            car car = db.cars.Find(id);
            db.cars.Remove(car);
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
