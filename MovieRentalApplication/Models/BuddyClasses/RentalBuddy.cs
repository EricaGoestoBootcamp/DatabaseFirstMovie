using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalApplication.Models
{
    [MetadataType(typeof(RentalBuddy))]

    public partial class Rental
        { }
    sealed  class RentalBuddy
    {
        public int RentalID { get; set; }
        public int CustomerID { get; set; }
        public int MovieID { get; set; }
        [Display(Name = "Rental Date")]
        public System.DateTime DateRented { get; set; }
    }
}