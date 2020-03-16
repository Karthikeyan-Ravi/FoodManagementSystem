//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FoodManagementSystem.Entity
//{
//    public class RestaurantCuisine
//    {
//        [Key]
//        public int RestaurantCuisineID
//        {
//            get;
//            set;
//        }
//        public int RestaurantID
//        {
//            get;
//            set;
//        }
//        public Restaurant Restaurant
//        {
//            get;
//            set;
//        }
//        public int CuisineID
//        {
//            get;
//            set;
//        }
//        public Cuisine Cuisine
//        {
//            get;
//            set;
//        }
//        public ICollection<Restaurant> Restaurants { get; set; }
//        public ICollection<Cuisine> Cuisines { get; set; }
//        public RestaurantCuisine()
//        { }

//    }
//}
