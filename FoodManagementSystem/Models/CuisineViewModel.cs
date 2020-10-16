using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Index(IsUnique = true)]
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