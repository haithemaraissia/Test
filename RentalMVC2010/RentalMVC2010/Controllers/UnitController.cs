using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentalMVC2010.Models;

namespace RentalMVC2010.Controllers
{ 
    public class UnitController : Controller
    {
        private RentalDB db = new RentalDB();

        //
        // GET: /Unit/

        public ViewResult Index()
        {
            return View(db.Units.ToList());
        }

        //
        // GET: /Unit/Details/5

        public ActionResult Details(int id)
        {
            Unit unit = db.Units.Find(id);
            if (unit == null)
            {
                return HttpNotFound();
            }
            return View(unit);
        }

        //
        // GET: /Unit/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Unit/Create

        [HttpPost]
        public ActionResult Create(Unit unit)
        {
            if (ModelState.IsValid)
            {
                db.Units.Add(unit);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(unit);
        }
        
        //
        // GET: /Unit/Edit/5
 
        public ActionResult Edit(int id)
        {
            Unit unit = db.Units.Find(id);
            return View(unit);
        }

        //
        // POST: /Unit/Edit/5

        [HttpPost]
        public ActionResult Edit(Unit unit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unit);
        }

        //
        // GET: /Unit/Delete/5
 
        public ActionResult Delete(int id)
        {
            Unit unit = db.Units.Find(id);

            var galleryimages =  db.UnitGallery.Where(x => x.UnitId == id).OrderByDescending(x=>x.Rank).ToArray();
            //if (galleryimages.Count)
            //ViewBag["Image1"]


            //OVER HERE TFOR THE PLUGIN
            return View(unit);
        }

        //
        // POST: /Unit/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Unit unit = db.Units.Find(id);
            db.Units.Remove(unit);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}