using System.ComponentModel.DataAnnotations;

namespace FoodManagementSystem.Models
{
    public class RestaurantViewModel
    {
        //Primary key attribute
        [Key]
        public int RestaurantID         //Attributes of RestaurantViewModel
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
        [Required(ErrorMessage = "Location required")]
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
        //Foreign key attribute
        [Required(ErrorMessage ="Cuisine name required")]
        public int CuisineID
        {
            get;
            set;
        }
        public CuisineViewModel Cuisine
        {
            get;
            set;
        }
    }
}