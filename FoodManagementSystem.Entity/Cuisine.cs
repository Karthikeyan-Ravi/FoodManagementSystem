using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodManagementSystem.Entity
{
    public class Cuisine
    {
        //Primary key attribute
        [Key]
        public int CuisineID
        {
            get;
            set;
        }
        [Index(IsUnique = true)]
        [Required]
        [MaxLength(20)]
        public string CuisineName
        {
            get;
            set;
        }
        public Cuisine()
        { }
    }
}
