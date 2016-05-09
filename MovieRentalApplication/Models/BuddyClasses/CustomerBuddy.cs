using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalApplication.Models
{
    [MetadataType(typeof(CustomerBuddy))]

    public partial class Customer
    {
        public string FullName
        {
            get { return FirstName + " " + LastName; }
            set { }
        }
    }
    sealed class CustomerBuddy
    {
        public int CustomerID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
    }
}