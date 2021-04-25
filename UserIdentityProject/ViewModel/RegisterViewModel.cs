using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserIdentityProject.ViewModel
{
    public class RegisterViewModel
    {
        //[Required]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        //[Required]
        [RegularExpression("([0-9]*)", ErrorMessage = "Please enter a valid phone number.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Please enter a valid phone number.")]
        public string PhoneNumber { get; set; }

        //[Required]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //[Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password not match.")]
        public string ConfirmPassword { get; set; }
    }
}
