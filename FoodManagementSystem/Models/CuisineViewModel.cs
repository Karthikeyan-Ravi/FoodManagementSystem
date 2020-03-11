using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodManagementSystem.Models
{
    public class CuisineViewModel
    {
        [Key]
        public int CuisineID
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
    }
}