using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodManagementSystem.Models
{
    
        public enum Gender
        {
            M,
            F,
            O
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
            [MaxLength(8)]
            [RegularExpression(@"([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{3,15}", ErrorMessage = "Invalid Password")]
            public string Password
            {
                get;
                set;
            }
            public string Role
            {
                get;
                set;
            }
        }
}