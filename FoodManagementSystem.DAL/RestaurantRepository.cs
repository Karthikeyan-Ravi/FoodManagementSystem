using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.DAL
{
    public class RestaurantRepository
    {
        //FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext();
        public void AddRestaurant(Restaurant restaurant)
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                dbContext.Restaurants.Add(restaurant);
                dbContext.SaveChanges();
            }
        }
        public List<Restaurant> GetRestaurantDetails()
        {
            using (FoodManagementSystemDBContext foodManagementDBContext = new FoodManagementSystemDBContext())
            {
                return foodManagementDBContext.Restaurants.ToList();
            }
        }
        public Restaurant GetRestaurantId(int restaurantId)
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                return dbContext.Restaurants.Where(id => id.RestaurantID == restaurantId).SingleOrDefault();
            }
        }
        public void UpdateRestaurant(Restaurant restaurantFields)
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                dbContext.Entry(restaurantFields).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }
        public void DeleteRestaurant(Restaurant restaurantFields)
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                //RestaurantFields restaurantFields = GetRestaurantId(id);
                dbContext.Restaurants.Attach(restaurantFields);
                dbContext.Restaurants.Remove(restaurantFields);
                dbContext.SaveChanges();
            }
        }
    }
}