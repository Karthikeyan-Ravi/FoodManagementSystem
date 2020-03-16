using FoodManagementSystem.DAL;
using System.Data;
using FoodManagementSystem.Entity;
using System.Collections.Generic;

namespace FoodManagementSystem.BL
{
    public class RestaurantBL
    {
        RestaurantRepository restaurantRepository = new RestaurantRepository();
        //public DataTable DisplayRestaurantDetails()
        //{
        //    return restaurantRepository.DisplayRestaurantDetails();
        //}
        //public void UpdateRestaurantDetails(string name, string type, string location, int id)
        //{
        //    restaurantRepository.UpdateRestaurantDetails(name, type, location, id);
        //}
        //public void DeleteRestaurantDetails(int id)
        //{
        //    restaurantRepository.DeleteRestaurantDetails(id);
        //}
        public void AddtRestaurant(Restaurant restaurant)
        {
            restaurantRepository.AddRestaurant(restaurant);
        }  
        public IEnumerable<Restaurant> GetRestaurantDetails()
        {
            return restaurantRepository.GetRestaurantDetails();
        }     
        public Restaurant GetRestaurantId(int id)
        {
            return restaurantRepository.GetRestaurantId(id);
        }
        public void UpdateRestaurant(Restaurant restaurantFields)
        {
            restaurantRepository.UpdateRestaurant(restaurantFields);
        }
        public void DeleteRestaurant(Restaurant restaurantFields)
        {
            restaurantRepository.DeleteRestaurant(restaurantFields);
        }
    }
}
  