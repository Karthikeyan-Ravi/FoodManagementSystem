using FoodManagementSystem.DAL;
using FoodManagementSystem.Entity;
using System.Collections.Generic;

namespace FoodManagementSystem.BL
{
    // interface declaration 
    public interface IResturant
    {
        // declaration of methods of 
        // interface that will be implemented  
        // by the class which inherits the interface 
        void AddRestaurant(Restaurant restaurant);
        IEnumerable<Restaurant> GetRestaurantDetails();
        Restaurant GetRestaurantId(int id);
        void UpdateRestaurant(Restaurant restaurantFields);
        void DeleteRestaurant(int restaurantId);
        //IEnumerable<Restaurant> GetRestaurantDetailsForDelete(int restaurantId);
    }
    public class RestaurantBL: IResturant            //Implementing the interfce
    {
        //creating an Reference of interface
        IRestaurantRepository restaurantRepository;
        public RestaurantBL()
        {
            // Declare an interface instance
            restaurantRepository = new RestaurantRepository();
        }
        public void AddRestaurant(Restaurant restaurant)
        {
            restaurantRepository.AddRestaurant(restaurant);
        }
        //Retrieves the restaurant details
        public IEnumerable<Restaurant> GetRestaurantDetails()
        {
            return restaurantRepository.GetRestaurantDetails();
        }
        //Method to get restaurant details based on id
        public Restaurant GetRestaurantId(int id)
        {
            return restaurantRepository.GetRestaurantId(id);
        }
        //Method to update the restaurant details
        public void UpdateRestaurant(Restaurant restaurantFields)
        {
            restaurantRepository.UpdateRestaurant(restaurantFields);
        }
        //Method to delete the restaurant details 
        public void DeleteRestaurant(int restaurantId)
        {
            restaurantRepository.DeleteRestaurant(restaurantId);
        }
        //public IEnumerable<Restaurant> GetRestaurantDetailsForDelete(int restaurantId)
        //{
        //    return restaurantRepository.GetRestaurantDetailsForDelete(restaurantId);
        //}
    }
}
  