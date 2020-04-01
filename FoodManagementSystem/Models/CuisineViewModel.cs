using System.ComponentModel.DataAnnotations;

namespace FoodManagementSystem.Models
{
    public class CuisineViewModel
    {
        //Primary key attribute
        [Key]
        public int CuisineID        //Attributes of CuisineViewModel
        {
            get;
            set;
        }
        [Required]
        [Display(Name ="CuisineName")]
        public string CuisineName
        {
            get;
            set;
        }
        //public ICollection<Restaurant> Restaurant { get; set; }
    }
}