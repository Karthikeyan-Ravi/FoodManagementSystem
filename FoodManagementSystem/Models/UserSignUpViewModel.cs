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
        Femlae,
        Others
    }
    public class UserSignUpViewModel
    {
        [Required(ErrorMessage = "Name required")]
        [Display(Name = "FullName")]
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
        [Display(Name = "Password")]
        [MaxLength(10)]
        [RegularExpression("^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?!.*s).*$", ErrorMessage = "Password should contain Uppercase,Lowecase,Symbol and Number")]
        public string Password
        {
            get;
            set;
        }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confrim Password")]
        [Compare("Password",ErrorMessage ="Password doesn't match")]
        public string ConfirmPassword
        {
            get;
            set;
        }
        [Required]
        public string Role
        {
            get;
            set;
        }
    }
}