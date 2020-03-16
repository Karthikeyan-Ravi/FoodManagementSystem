using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.Entity
{
    public class Restaurant
    {
        [Key]
        public int RestaurantID
        {
            get;
            set;
        }
        [Required]
        public string RestaurantName
        {
            get;
            set;
        }
         
        [Required]
        public string Location
        {
            get;
            set;
        }
        [Required]
        public long PhoneNumber
        {
            get;
            set;
        }
        public int CuisineID
        {
            get;
            set;
        }
        public Cuisine Cuisine
        {
            get;
            set;
        }
        //public ICollection<RestaurantCuisine> RestaurantCuisines { get; set; }
        //public ICollection<Cuisine> Cuisines { get; set; }
        public Restaurant()
        {
        }
     }
}
