using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodManagementSystem.Models
{
    public class RestaurantCuisineViewModel
    {
        [Key]
        public int RestaurantCuisineID
        {
            get;
            set;
        }
        public int RestaurantID
        {
            get;
            set;
        }
        public Restaurant Restaurant
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
    }
}