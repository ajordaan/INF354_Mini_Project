using System;
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
    public class rentalsController : Controller
    {
        private furnatureEntities db = new furnatureEntities();

        // GET: rentals
        public ActionResult Index()
        {
            var rentals = db.rentals.Include(r => r.car).Include(r => r.customer);
            return View(rentals.ToList());
        }

        // GET: rentals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rental rental = db.rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            return View(rental);
        }

        // GET: rentals/Create
        public ActionResult Create()
        {
            ViewBag.car_id = new SelectList(db.cars, "car_id", "car_make");
            ViewBag.customer_id = new SelectList(db.customers, "customer_id", "first_name");
            return View();
        }

        // POST: rentals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "rental_id,customer_id,car_id,date_from,date_to")] rental rental)
        {
            if (ModelState.IsValid)
            {
                db.rentals.Add(rental);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.car_id = new SelectList(db.cars, "car_id", "car_make", rental.car_id);
            ViewBag.customer_id = new SelectList(db.customers, "customer_id", "first_name", rental.customer_id);
            return View(rental);
        }

        // GET: rentals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rental rental = db.rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            ViewBag.car_id = new SelectList(db.cars, "car_id", "car_make", rental.car_id);
            ViewBag.customer_id = new SelectList(db.customers, "customer_id", "first_name", rental.customer_id);
            return View(rental);
        }

        // POST: rentals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "rental_id,customer_id,car_id,date_from,date_to")] rental rental)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rental).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.car_id = new SelectList(db.cars, "car_id", "car_make", rental.car_id);
            ViewBag.customer_id = new SelectList(db.customers, "customer_id", "first_name", rental.customer_id);
            return View(rental);
        }

        // GET: rentals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rental rental = db.rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            return View(rental);
        }

        // POST: rentals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            rental rental = db.rentals.Find(id);
            db.rentals.Remove(rental);
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
