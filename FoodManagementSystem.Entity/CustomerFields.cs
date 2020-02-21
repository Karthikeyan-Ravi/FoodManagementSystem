using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.Entity
{
    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public class CustomerFields
    {
        [Required(ErrorMessage ="Name required")]
        [MaxLength(5)]
        public string FullName
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Phone number required")]
        [DataType(DataType.PhoneNumber),MaxLength(10)]
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
        public string Mail
        {
            get;
            set;
        }
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})", ErrorMessage ="Invalid Password")]
        public string Password
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
        public CustomerFields()
        {

        }
        public CustomerFields(string fullName, long phoneNumber, string mail, string password, string role)
        {
            this.FullName = fullName;
            this.PhoneNumber = phoneNumber;
            this.Mail = mail;
            this.Password = password;
            this.Role = role;
        }
    }
}
