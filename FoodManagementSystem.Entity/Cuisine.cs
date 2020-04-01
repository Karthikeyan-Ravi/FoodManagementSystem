using System.ComponentModel.DataAnnotations;


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
        [Required]
        public string CuisineName
        {
            get;
            set;
        }
        public Cuisine()
        { }
    }
}
