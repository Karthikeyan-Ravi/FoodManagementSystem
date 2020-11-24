using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using System.Web.WebPages.Html;

namespace FoodManagementSystem.Models
{
    public class Payment
    {
        [Required]
        [RegularExpression(@"/^(?:4[0-9]{12}(?:[0-9]{3})?)$/;",ErrorMessage ="Incorrect account number")]
        public long AccountNo { get; set; }
        [Required]
        [RegularExpression(@"^[A-Za-z]+$",ErrorMessage ="Incoorect format")]
        public string NameOnTheCard { get; set; }
        [Required]
        public int ExpiryMonth { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        [RegularExpression(@"/[0-9][0-9][0-9]/;",ErrorMessage ="Incorrect format")]
        public int CVV { get; set; }
    }
}