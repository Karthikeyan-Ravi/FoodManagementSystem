using FoodManagementSystem.Entity;
using System.Collections.Generic;
using System.Linq;

namespace FoodManagementSystem.DAL
{
    // interface declaration 
    public interface IRestaurantRepository
    {
        // declaration of methods of 
        // interface that will be implemented  
        // by the class which inherits the interface 
        void AddRestaurant(Restaurant restaurant);
        IEnumerable<Restaurant> GetRestaurantDetails();
        Restaurant GetRestaurantId(int restaurantId);
        void UpdateRestaurant(Restaurant restaurantFields);
        void DeleteRestaurant(int restaurantId);
        //IEnumerable<Restaurant> GetRestaurantDetailsForDelete(int restaurantId);
    }
    public class RestaurantRepository: IRestaurantRepository        //Implementing the interfce
    {
        //FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext();
        public void AddRestaurant(Restaurant restaurant)            //Method to Add restaurant to repository
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                dbContext.Restaurants.Add(restaurant);
                dbContext.SaveChanges();
            }
        }
       
        public IEnumerable<Restaurant> GetRestaurantDetails()       //Method to get all the restaurant details
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                return dbContext.Restaurants.Include("Cuisine").ToList();
            }
        }
        public Restaurant GetRestaurantId(int restaurantId)         //Method to get restaurant details based on id
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                return dbContext.Restaurants.Find(restaurantId);//.Where(id =>id.RestaurantID == restaurantId).SingleOrDefault();
                
            }
        }
        public void UpdateRestaurant(Restaurant restaurantFields)   //Method to update the restaurant details
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
               // Restaurant restaurant= GetRestaurantId(restaurantFields.RestaurantID);
                dbContext.Entry(restaurantFields).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }
        public void DeleteRestaurant(int restaurantId)      //Method to delete the restaurant details 
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                //SqlParameter RestaurantID = new SqlParameter("@RestaurantID",restaurantFields.RestaurantID);
                //var result=dbContext.Database.ExecuteSqlCommand.spname
                Restaurant restaurantFields = GetRestaurantId(restaurantId);
                dbContext.Restaurants.Attach(restaurantFields);
                dbContext.Restaurants.Remove(restaurantFields);
                dbContext.SaveChanges();
            }
        }
    }
}