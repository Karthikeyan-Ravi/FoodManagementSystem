using System.ComponentModel.DataAnnotations;


namespace FoodManagementSystem.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Email required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Mail")]
        public string Mail      //Attributes of UserSignInViewModel
        {
            get;
            set;
        }
        [Required(ErrorMessage ="Password required")]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        //[RegularExpression(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})", ErrorMessage = "Invalid Password")]
        public string Password
        {
            get;
            set;
        }
    }
}