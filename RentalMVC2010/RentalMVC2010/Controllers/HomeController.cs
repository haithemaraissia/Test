using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentalMVC2010.Models;

namespace RentalMVC2010.Controllers
{
    public class HomeController : Controller
    {
        private  RentalDB _rentalDB = new RentalDB();
        
        public ActionResult Index()
        {
            //var model = _rentalDB.Units.ToList();

            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
          //  return View(model);

      //     return TestView(model);
        }





        public ActionResult About()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (_rentalDB != null)
            {
                _rentalDB.Dispose();
            }
               base.Dispose(disposing);
        }










        public string GetImage(string image)
        {
            var path ="/images/" + image;
            return path;
        }


        public ActionResult TestView()
        {
            var model = _rentalDB.Units;

            return View(model);
       }

        //public ActionResult Edit(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public ActionResult Details(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public ActionResult Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public ActionResult Create()
        //{
        //    throw new NotImplementedException();
        //}
        public ActionResult Details(int UnitId)
        {
            //Movie movie = db.Movies.Find(id);
            //return View(movie);

            var model = _rentalDB.Units.Find(UnitId);
            return View(model);
        }
    }
}
