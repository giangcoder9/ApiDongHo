using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class RegisterVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
       
        public string Password { get; set; }

        [Required]
        
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
