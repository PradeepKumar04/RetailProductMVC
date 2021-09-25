using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name ="Email")]
        public string Email { get; set; }
        public string  Address  { get; set; }
        public int Zipcode { get; set; }
        public string Password  { get; set; }
        [Compare("Password", ErrorMessage ="Both Password and Confirm Password Must be Equal")]
        public string ConfirmPassword { get; set; }
    }
}
