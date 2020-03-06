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
        FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext();
        public void AddRestaurant(RestaurantFields restaurantFields)
        {
            
            dbContext.Restaurant.Add(restaurantFields);
            dbContext.SaveChanges();
        }
        public List<RestaurantFields> GetRestaurantDetails()
        {
            FoodManagementSystemDBContext foodManagementDBContext = new FoodManagementSystemDBContext();
            return foodManagementDBContext.Restaurant.ToList();
        }
        public RestaurantFields GetRestaurantId(int restaurantId)
        {
            return dbContext.Restaurant.Where(id => id.RestaurantID == restaurantId).SingleOrDefault();
        }
        public void UpdateRestaurant(RestaurantFields restaurantFields)
        {
            dbContext.Entry(restaurantFields).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }
        public void DeleteRestaurant(RestaurantFields restaurantFields)
        {
            //RestaurantFields restaurantFields = GetRestaurantId(id);
            dbContext.Restaurant.Attach(restaurantFields);
            dbContext.Restaurant.Remove(restaurantFields);
            dbContext.SaveChanges();
        }
    }
}