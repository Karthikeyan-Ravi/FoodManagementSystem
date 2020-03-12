using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodManagementSystem.Models
{
    public class FoodViewModel
    {
        public int FoodID
        {
            get;
            set;
        }
        public int RestaurantID
        {
            get;
            set;
        }
        public Restaurant RestaurantFields
        {
            get;
            set;
        }
        public string FoodName
        {
            get;
            set;
        }
        public int FoodCategoryID
        {
            get;
            set;
        }
        public FoodCategory FoodCategory { get; set; }
        public string FoodPrice
        {
            get;
            set;
        }
    }
}