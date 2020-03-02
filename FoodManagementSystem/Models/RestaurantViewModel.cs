using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FoodManagementSystem.Models
{
    public class RestaurantViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RestaurantID
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
        [Required(ErrorMessage = "Name required")]
        [Display(Name = "RestaurantType")]
        public string RestaurantType
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Name required")]
        [Display(Name = "Location")]
        public string Location
        {
            get;
            set;
        }
    }
}