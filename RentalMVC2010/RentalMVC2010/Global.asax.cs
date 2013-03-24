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

            routes.MapRoute(
                "Gallery",
               "{controller}/{action}/{id}",
                new { controller = "UnitGallery", action = "Index", id = UrlParameter.Optional }
            );

        }

        protected void Application_Start()
        {

            Database.SetInitializer(new RentalDBInitializer());
            var ctx = new RentalDB();
            ctx.Database.Initialize(true);

            ViewEngines.Engines.Add(new MobileViewEngine());
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }

    public class RentalDBInitializer : DropCreateDatabaseAlways<RentalDB>
    {
        protected override void Seed(RentalDB context)
        {
            base.Seed(context);


            var myUnit1 = new Unit
                                {
                                    Address = "1225 south strange line",
                                    Bathroom = 2,
                                    Bed = 2,
                                    City = "Olathe",
                                    State = "KS",
                                    Description =
                                        "This adorable townhome is waiting just for you. Great room; formal dining area, kitchen with breakfast area; assigned parking; close to area shopping and I-85.",
                                    SquareFoot = 1400,
                                    YearBuilt = DateTime.Now.Year,
                                    PrimaryImagePath = "home.jpg"
                                };


            var myUnit2 = new Unit
            {
                Address = "1225 south strange line",
                Bathroom = 2,
                Bed = 2,
                City = "Olathe",
                State = "KS",
                Description =
                    "This adorable townhome is waiting just for you. Great room; formal dining area, kitchen with breakfast area; assigned parking; close to area shopping and I-85.",
                SquareFoot = 1400,
                YearBuilt = DateTime.Now.Year,
                PrimaryImagePath = "home.jpg"
            };


            var myUnit3 = new Unit
            {
                Address = "1225 south strange line",
                Bathroom = 2,
                Bed = 2,
                City = "Olathe",
                State = "KS",
                Description =
                    "This adorable townhome is waiting just for you. Great room; formal dining area, kitchen with breakfast area; assigned parking; close to area shopping and I-85.",
                SquareFoot = 1400,
                YearBuilt = DateTime.Now.Year,
                PrimaryImagePath = "home.jpg"
            };

            context.Units.Add(myUnit1);
            context.Units.Add(myUnit2);
            context.Units.Add(myUnit3);



            context.UnitGallery.Add(new UnitGallery

                                        {
                                            Caption = "Home",
                                            Path = "Home2.jpg",
                                            Rank = 2,
                                            Id = 1,
                                            UnitId = myUnit1.UnitId,
                                            Unit_1 = myUnit1,

                                            Unit_UnitId = myUnit1.UnitId

                                        }
                );



            context.UnitGallery.Add(new UnitGallery

            {
                Caption = "Home",
                Path = "Home3.jpg",
                Rank = 3,
                Id = 1,
                UnitId = myUnit1.UnitId,
                Unit_1 = myUnit1,

                Unit_UnitId = myUnit1.UnitId

            }
              );


            context.UnitGallery.Add(new UnitGallery

            {
                Caption = "Home",
                Path = "Home.jpg",
                Rank = 1,
                Id = 1,
                UnitId = myUnit1.UnitId,
                Unit_1 = myUnit1,

                Unit_UnitId = myUnit1.UnitId

            }
              );


            context.UnitGallery.Add(new UnitGallery

            {
                Caption = "Home",
                Path = "Home4.jpg",
                Rank = 1,
                Id = 1,
                UnitId = myUnit2.UnitId,
                Unit_1 = myUnit2,

                Unit_UnitId = myUnit2.UnitId

            }
              );

            context.UnitGallery.Add(new UnitGallery

            {
                Caption = "Home",
                Path = "Home5.jpg",
                Rank = 2,
                Id = 2,
                UnitId = myUnit2.UnitId,
                Unit_1 = myUnit2,

                Unit_UnitId = myUnit2.UnitId

            }
              );

            context.UnitGallery.Add(new UnitGallery

            {
                Caption = "Home",
                Path = "Home6.jpg",
                Rank = 4,
                Id = 2,
                UnitId = myUnit2.UnitId,
                Unit_1 = myUnit2,

                Unit_UnitId = myUnit2.UnitId

            }
              );
            context.SaveChanges();
        }
    }
}