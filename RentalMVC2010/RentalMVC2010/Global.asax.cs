using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using RentalMVC2010.Models;

namespace RentalMVC2010
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {

            Database.SetInitializer(new RentalDBInitializer());
            ViewEngines.Engines.Add(new MobileViewEngine());
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }

    public class RentalDBInitializer : DropCreateDatabaseIfModelChanges<RentalDB>
    {
        protected override void Seed(RentalDB context)
        {
            base.Seed(context);

            context.Units.Add(new Unit
                {
                    Address = "dsfs",
                    Bathroom = 2,
                    Bed = 2,
                    City = "Olathe",
                    State = "KS",
                    Description = "Descriotion",
                    SquareFoot = 1400,
                    YearBuilt = DateTime.Now.Year,
                    PrimaryImagePath = "home.jpg"
                });

            context.Units.Add(new Unit
            {
                Address = "dsfs",
                Bathroom = 3,
                Bed = 2,
                City = "Olathe",
                State = "KS",
                Description = "Descriotion",
                SquareFoot = 1400,
                YearBuilt = DateTime.Now.Year,
                PrimaryImagePath = "home.jpg"
            });
            context.SaveChanges();
        }
    }
}