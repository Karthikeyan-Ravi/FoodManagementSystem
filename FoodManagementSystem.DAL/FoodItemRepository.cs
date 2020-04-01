using FoodManagementSystem.Entity;
using System.Collections.Generic;
using System.Linq;

namespace FoodManagementSystem.DAL
{
    // interface declaration 
    public interface IFoodItemRepository
    {
        // declaration of methods of 
        // interface that will be implemented  
        // by the class which inherits the interface 
        IEnumerable<FoodItem> GetFoodDetails();
        IEnumerable<FoodCategory> GetFoodCategories();
        void AddFood(FoodItem foodItem);
        IEnumerable<FoodItem> DisplayRestaurantFoods(int restaurantId);
        FoodItem GetFoodDetailsById(int foodId);
        void UpdateFood(FoodItem foodItem);
        void DeleteFood(int foodId);
    }
    public class FoodItemRepository: IFoodItemRepository     //Implementing the interfce
    {
        public IEnumerable<FoodItem> GetFoodDetails()       //Method to Retrieve the Food details
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                return dbContext.FoodItems.Include("RestaurantFields").Include("FoodCategory").ToList();
            }
        }
        public IEnumerable<FoodItem> DisplayRestaurantFoods(int restaurantId) //Method to Retrieve the Particular restaurant foods
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                return dbContext.FoodItems.Include("FoodCategory").Where(id => id.RestaurantID == restaurantId).ToList();
            }
        }
        public FoodItem GetFoodDetailsById(int foodId)  //Method which Retrieves the food based on id
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                return dbContext.FoodItems.Find(foodId);
            }
        } 
        public IEnumerable<FoodCategory> GetFoodCategories() //Method which Retrieves the food categories
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                return dbContext.FoodCategories.ToList();
            }
        }
        public void AddFood(FoodItem foodItem)      //Method to Add food to db
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                dbContext.FoodItems.Add(foodItem);
                dbContext.SaveChanges();
            }
        }
        public void UpdateFood(FoodItem foodItem)   //Method to update the existing food 
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                dbContext.Entry(foodItem).State= System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }
        public void DeleteFood(int foodId)      //Method to delete the food
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                FoodItem foodItem = GetFoodDetailsById(foodId);
                dbContext.FoodItems.Attach(foodItem);
                dbContext.FoodItems.Remove(foodItem);
                dbContext.SaveChanges();
            }
        } 
    }
}
