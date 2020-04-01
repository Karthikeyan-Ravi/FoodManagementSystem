using FoodManagementSystem.Entity;
using System.ComponentModel.DataAnnotations;

namespace FoodManagementSystem.Models
{
    public class FoodViewModel
    {
        //Primary key attribute
        [Key]
        public int FoodID           //Attributes of FoodViewModel
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
        public RestaurantViewModel RestaurantFields
        {
            get;
            set;
        }
        [Required(ErrorMessage = "FoodName required")]
        [Display(Name = "FoodName")]
        public string FoodName
        {
            get;
            set;
        }
        //Foreign key attribute
        [Required(ErrorMessage ="Food category required")]
        public int FoodCategoryID
        {
            get;
            set;
        }
        public FoodCategory FoodCategory { get; set; }
        [Required(ErrorMessage = "FoodPrice required")]
        [Display(Name = "FoodPrice")]
        public string FoodPrice
        {
            get;
            set;
        }
    }
}