using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.Entity
{
    public class FoodCategory
    {
        [Key]
        public int FoodCategoryID
        {
            get;
            set;
        }
        public string CategoryName
        {
            get;
            set;
        }
 
    }
}
