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
        [Required]
        public string FirstName { get; set; }
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Display(Name = "User Name")]
        [Required]
        public string UserName { get; set; }
        [Display(Name ="Phone Number")]
        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string  Address  { get; set; }
        public int Zipcode { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(10)]
        public string Password  { get; set; }
        [Compare("Password", ErrorMessage ="Both Password and Confirm Password Must be Equal")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
