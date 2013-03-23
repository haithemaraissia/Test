using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace RentalMVC2010.Models
{

    public class Unit
    {
        [Key]
        public int UnitId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }


      //More to come
        public int Bed { get; set; }
        public Double Bathroom { get; set; }
        public Double SquareFoot { get; set; }
        public int YearBuilt { get; set; }
        //More to come


        public string Description { get; set; }
        public string PrimaryImagePath { get; set; }
       
    }

}
