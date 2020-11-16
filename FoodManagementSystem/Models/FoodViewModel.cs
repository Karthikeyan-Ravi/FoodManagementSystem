using FoodManagementSystem.Entity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

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
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Please enter valid Number")]
        [Display(Name = "FoodPrice")]
        [Range(typeof(Decimal), "1", "9999", ErrorMessage = "Price should be greater than 0 and 9999")]
        public string FoodPrice
        {
            get;
            set;
        }
        public string FoodImagePath
        {
            get;
            set;
        }
        [Required(ErrorMessage ="Food image required")]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}
