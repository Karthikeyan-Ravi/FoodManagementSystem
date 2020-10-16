using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FoodManagementSystem.Entity
{
    //public enum Gender
    //{
    //    Male,
    //    Female,
    //    Others
    //}
    public class Customer
    {
        //Primary key attribute
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID
        {
            get;
            set;
        }
        [MaxLength(30)]
        [Required(ErrorMessage = "Name required")]
        public string FullName                      //Attributes of Customer
        {
            get;
            set;
        }
        [Index(IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone number required")]
        public long PhoneNumber
        {
            get;
            set;
        }
        [Required(ErrorMessage ="Gender required")]
        public string Gender
        {
            get;
            set;
        }
        [Index(IsUnique = true)]
        [DataType(DataType.EmailAddress)]
        [MaxLength(30)]
        [Required(ErrorMessage = "Email required")]
        public string Mail
        {
            get;
            set;
        }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(12)]
        public string Password
        {
            get;
            set;
        }
        [DataType(DataType.Password)]
        [MaxLength(12)]
        [Required(ErrorMessage ="Confirm password required")]
        public string ConfirmPassword
        {
            get;
            set;
        }
        [Required(ErrorMessage ="Role required")]
        public string Role
        {
            get;
            set;
        }
        public Customer()
        {

        }
    }

}
   