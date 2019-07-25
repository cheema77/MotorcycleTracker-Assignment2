using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MotorcycleTracker.Models;

namespace MotorcycleTracker.Controllers
{
    public class MotorcycleDetailsController : Controller
    {
        private MotorcycleDetailModel db = new MotorcycleDetailModel();

        // GET: MotorcycleDetails
        public ActionResult Index()
        {
            var motorcycleDetails = db.MotorcycleDetails.Include(m => m.Motorcycle);
            return View(motorcycleDetails.ToList());
        }

        // GET: MotorcycleDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MotorcycleDetail motorcycleDetail = db.MotorcycleDetails.Find(id);
            if (motorcycleDetail == null)
            {
                return HttpNotFound();
            }
            return View(motorcycleDetail);
        }
        [Authorize]
        // GET: MotorcycleDetails/Create
        public ActionResult Create()
        {
            ViewBag.MotorId = new SelectList(db.Motorcycles, "MotorId", "MotorName");
            return View();
        }

        // POST: MotorcycleDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DetailsId,MotorId,MotorBrand,MotorModel,Country")] MotorcycleDetail motorcycleDetail)
        {
            if (ModelState.IsValid)
            {
                db.MotorcycleDetails.Add(motorcycleDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MotorId = new SelectList(db.Motorcycles, "MotorId", "MotorName", motorcycleDetail.MotorId);
            return View(motorcycleDetail);
        }
        [Authorize]
        // GET: MotorcycleDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MotorcycleDetail motorcycleDetail = db.MotorcycleDetails.Find(id);
            if (motorcycleDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.MotorId = new SelectList(db.Motorcycles, "MotorId", "MotorName", motorcycleDetail.MotorId);
            return View(motorcycleDetail);
        }

        // POST: MotorcycleDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DetailsId,MotorId,MotorBrand,MotorModel,Country")] MotorcycleDetail motorcycleDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(motorcycleDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MotorId = new SelectList(db.Motorcycles, "MotorId", "MotorName", motorcycleDetail.MotorId);
            return View(motorcycleDetail);
        }

        [Authorize]
        // GET: MotorcycleDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MotorcycleDetail motorcycleDetail = db.MotorcycleDetails.Find(id);
            if (motorcycleDetail == null)
            {
                return HttpNotFound();
            }
            return View(motorcycleDetail);
        }

        [Authorize]
        // POST: MotorcycleDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MotorcycleDetail motorcycleDetail = db.MotorcycleDetails.Find(id);
            db.MotorcycleDetails.Remove(motorcycleDetail);
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
