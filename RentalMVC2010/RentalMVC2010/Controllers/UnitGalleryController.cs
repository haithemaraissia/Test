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
    public class UnitGalleryController : Controller
    {
        private RentalDB db = new RentalDB();

        //
        // GET: /UnitGallery/

        //public ViewResult Index()
        //{
        //    return View(db.UnitGallery.ToList());
        //}


        public ViewResult Index(int unitid = 1)
        {
            var model = db.UnitGallery.Where(x => x.UnitId == unitid).ToList();
            if (model.Count == 0)
            {
                model = db.UnitGallery.ToList();
            }
            return View(model);
        }

        //
        // GET: /UnitGallery/Details/5

        public ViewResult Details(int id)
        {
            UnitGallery unitgallery = db.UnitGallery.Find(id);
            return View(unitgallery);
        }

        //
        // GET: /UnitGallery/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /UnitGallery/Create

        [HttpPost]
        public ActionResult Create(UnitGallery unitgallery)
        {
            if (ModelState.IsValid)
            {
                db.UnitGallery.Add(unitgallery);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(unitgallery);
        }
        
        //
        // GET: /UnitGallery/Edit/5
 
        public ActionResult Edit(int id)
        {
            UnitGallery unitgallery = db.UnitGallery.Find(id);
            return View(unitgallery);
        }

        //
        // POST: /UnitGallery/Edit/5

        [HttpPost]
        public ActionResult Edit(UnitGallery unitgallery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(unitgallery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(unitgallery);
        }

        //
        // GET: /UnitGallery/Delete/5
 
        public ActionResult Delete(int id)
        {
            UnitGallery unitgallery = db.UnitGallery.Find(id);
            return View(unitgallery);
        }

        //
        // POST: /UnitGallery/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            UnitGallery unitgallery = db.UnitGallery.Find(id);
            db.UnitGallery.Remove(unitgallery);
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