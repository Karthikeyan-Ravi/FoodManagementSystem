using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodManagementSystem.Models
{
    
        public enum Gender
        {
            Male,
            Female,
            Others
        }
        public class UserSignUpViewModel
        {
            [Required(ErrorMessage = "Name required")]
            [Display(Name ="FullName")]
            public string FullName
            {
                get;
                set;
            }
            [Required(ErrorMessage = "Phone number required")]
            [DataType(DataType.PhoneNumber)]
            [Display(Name = "PhoneNumber")]
            public long PhoneNumber
            {
                get;
                set;
            }
            public Gender Gender
            {
                get;
                set;
            }
            [Required(ErrorMessage = "Email required")]
            [DataType(DataType.EmailAddress)]
            [Display(Name = "Mail")]
            public string Mail
            {
                get;
                set;
            }
            [Required]
            [DataType(DataType.Password)]
            [Display(Name ="Password")]
            [RegularExpression(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})", ErrorMessage = "Invalid Password")]
            public string Password
            {
                get;
                set;
            }
            [Required]
            [Display(Name = "Role")]
            public string Role
            {
                get;
                set;
            }
        }
}