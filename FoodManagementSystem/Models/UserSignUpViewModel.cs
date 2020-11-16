using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodManagementSystem.Models
{
    //public enum Gender  
    //{
    //    Male,
    //    Female,
    //    Others
    //}
    public class UserSignUpViewModel
    {
        [Required(ErrorMessage = "Name required")]
        [Display(Name = "FullName")]
        public string FullName                  //Attributes of UserSignUpViewModel
        {
            get;
            set;
        }
        [Index(IsUnique = true)]
        [Required(ErrorMessage = "Phone number required")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "PhoneNumber")]
        public long PhoneNumber
        {
            get;
            set;
        }
        [Required(ErrorMessage ="Gender required")]
        [Display(Name ="Gender")]
        public string Gender
        {
            get;
            set;
        }
        [Index(IsUnique = true)]
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
        [RegularExpression(@"^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?!.*s).*$", ErrorMessage = "Password should contain Uppercase,Lowecase,Symbol and Number")]
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
        [Display(Name ="Role")]
        public string Role
        {
            get;
            set;
        }
    }
}