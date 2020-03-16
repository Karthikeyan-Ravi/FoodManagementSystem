using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FoodManagementSystem.Entity
{
    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Name required")]
        public string FullName
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Phone number required")]
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
        public string Mail
        {
            get;
            set;
        }
        [Required]
        public string Password
        {
            get;
            set;
        }
        [Required(ErrorMessage ="Confirm password required")]
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
        public Customer()
        {

        }
        //public CustomerFields(string fullName, long phoneNumber, string mail, string password, string role)
        //{
        //    this.FullName = fullName;
        //    this.PhoneNumber = phoneNumber;
        //    this.Mail = mail;
        //    this.Password = password;
        //    this.Role = role;
        //}
    }

}
   