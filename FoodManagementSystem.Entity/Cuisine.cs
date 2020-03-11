using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.Entity
{
    public class Cuisine
    {
        [Key]
        public int CuisineID
        {
            get;
            set;
        }
        [Required]
        public string CuisineName
        {
            get;
            set;
        }
        public ICollection<RestaurantCuisine> RestaurantCuisines { get; set; }
        public Cuisine()
        { }
    }
}
