﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.Entity
{
    public class FoodItem
    {
        [Key] 
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
        [Required]
        public string FoodName
        {
            get;
            set;
        }
        [Required]
        public int FoodCategoryID
        {
            get;
            set;
        }
        public FoodCategory FoodCategory { get; set; }
        [Required]
        public int FoodPrice
        {
            get;
            set;
        }
    }
}
