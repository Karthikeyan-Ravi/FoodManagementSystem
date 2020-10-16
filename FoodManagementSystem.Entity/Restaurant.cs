using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Index(IsUnique =true)]
        [Required]
        [MaxLength(25)]
        public string RestaurantName    //Attributes of restaurnt
        {
            get;
            set;
        }
         
        [Required]
        [MaxLength(20)]
        public string Location
        {
            get;
            set;
        }
        [Index(IsUnique = true)]
        [Required]
        [DataType(DataType.PhoneNumber)]
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
