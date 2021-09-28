using System.ComponentModel.DataAnnotations;

namespace EcommercePortalMVC.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        [RegularExpression(@"\d{5}([- ]*)\d{5}", ErrorMessage = "please enter valid phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        public int Zipcode { get; set; }
        [Required]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Both Password and Confirm Password Must be Equal")]
        [Required]
        public string ConfirmPassword { get; set; }
    }
}