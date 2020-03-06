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
        public RestaurantFields RestaurantFields
        {
            get;
            set;
        }
        public string FoodName
        {
            get;
            set;
        }
        public string FoodCategory
        {
            get;
            set;
        }
        public string FoodPrice
        {
            get;
            set;
        }
    }
}