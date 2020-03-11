using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodManagementSystem.Models
{
    public class RestaurantViewModel
    {
        [Key]
        public int RestaurantID
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Name required")]
        [Display(Name = "RestaurantName")]
        public string RestaurantName
        {
            get;
            set;
        }
        //[Required(ErrorMessage = "Cuisine required")]
        //public string Cuisines
        //{
        //    get;
        //    set;
        //}
        [Required(ErrorMessage = "Name required")]
        [Display(Name = "Location")]
        public string Location
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
        public ICollection<RestaurantCuisine> RestaurantCuisines { get; set; }
        public int[] restaurantCuisine
        {
            get;
            set;
        }
    }
}