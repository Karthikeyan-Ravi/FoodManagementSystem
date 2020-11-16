using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.Entity
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        [Required]
        public int UserId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        public int FoodId { get; set; }
        public FoodItem FoodItem { get; set; }
    }
}
