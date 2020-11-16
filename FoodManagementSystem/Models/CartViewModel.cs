using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodManagementSystem.Models
{
    public class CartViewModel
    {
        public int CartId { get; set; }
        [Required]
        public int UserId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        public int FoodId { get; set; }
        public FoodItem FoodItem { get; set; }
    }
}