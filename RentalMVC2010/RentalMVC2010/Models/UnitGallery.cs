using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace RentalMVC2010.Models
{
    public class UnitGallery
    {
        public int Id { get; set; }
        public string UnitId { get; set; }
        public string Path { get; set; }
        public string Caption { get; set; }
        public int Rank { get; set; }

    }
}
