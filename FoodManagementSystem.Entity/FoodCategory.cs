using System.ComponentModel.DataAnnotations;

namespace FoodManagementSystem.Entity
{
    public class FoodCategory
    {
        //Primary key attribute
        [Key]
        public int FoodCategoryID  //Attributes of Food category
        {
            get;
            set;
        }
        [Required]
        [MaxLength(7)]
        public string CategoryName
        {
            get;
            set;
        }
 
    }
}
