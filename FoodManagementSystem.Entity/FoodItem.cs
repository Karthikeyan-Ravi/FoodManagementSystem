using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodManagementSystem.Entity
{
    public class FoodItem
    {
        //Primary key attribute
        [Key] 
        public int FoodID
        {
            get;
            set;
        }
        //Foreign key attribute
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
        [Required(ErrorMessage = "FoodName required")]
        [MaxLength(20)]
        public string FoodName              //Attributes of Food items
        {
            get;
            set;
        }
        //Foreign key attribute
        [Required]
        public int FoodCategoryID
        {
            get;
            set;
        }
        public FoodCategory FoodCategory { get; set; }
        [Required(ErrorMessage = "FoodPrice required")]

        public int FoodPrice
        {
            get;
            set;
        }
        public string FoodImagePath
        {
            get;
            set;
        }
    }
}
