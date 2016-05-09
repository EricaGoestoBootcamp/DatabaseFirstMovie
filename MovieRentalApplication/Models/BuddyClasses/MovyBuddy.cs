using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalApplication.Models
{
    [MetadataType(typeof(MovyBuddy))]
   
    public partial class Movy
    { }


    sealed class MovyBuddy
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }

        [Display(Name = "Release Date")]
        public string ReleaseDate { get; set; }

    }
}