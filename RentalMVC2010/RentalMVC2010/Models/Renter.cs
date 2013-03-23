using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace RentalMVC2010.Models
{
      public class Renter
      {
          public int Id { get; set; }
          public string FirstName { get; set; }
          public string LastName { get; set; }
          public string Address { get; set; }
          public string City { get; set; }
          public string State { get; set; }

      }
}

