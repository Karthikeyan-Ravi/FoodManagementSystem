using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.Entity
{
    public class RestaurantFields
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RestaurantID
        {
            get;
            set;
        }
        [Required]
        public string RestaurantName
        {
            get;
            set;
        }
        [Required]
        public string RestaurantType
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
        public RestaurantFields()
        { }
        public RestaurantFields(string restaurantName, string restaurantType, string location)
        {
            this.RestaurantName = restaurantName;
            this.RestaurantType = restaurantType;
            this.Location = location;
        }

    }
}
