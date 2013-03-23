using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using RentalMVC2010.Models;


namespace RentalMVC2010.Models
{
    public class RentalDB : DbContext
    {
        //public RentalDB():base("RentalDB")
        //{
        //}

        public DbSet<Unit> Units { get; set; }
    }
}
