using System.ComponentModel.DataAnnotations;

namespace FoodManagementSystem.Entity
{
    public class Restaurant
    {
        //Primary key attribute
        [Key]
        public int RestaurantID
        {
            get;
            set;
        }
        [Required]
        public string RestaurantName    //Attributes of restaurnt
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
        //Foreign  key attribute
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
        public Restaurant()
        {
        }
     }
}
