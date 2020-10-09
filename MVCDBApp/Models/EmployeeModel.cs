using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDBApp.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee Id")]
        [Range(100000, 999999, ErrorMessage = "You need to enter valid employee id")]
        public int EmployeeId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to give us your first name!")]
        public string Firstname { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to give us your last name!")]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You need to give us your email address!")]
        public string EmailAddress { get; set; }
        [Display(Name = "Confirm Email Address")]
        [Compare("EmailAddress", ErrorMessage = "The Email and Confirm Email must match!")]
        public string ConfirmEmail { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must have a password!")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "You need to provide long enough password")]
        public string  Password { get; set; }
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your password and confirmed password do not match!")]
        public string ConfirmPassword { get; set; }

    }
}