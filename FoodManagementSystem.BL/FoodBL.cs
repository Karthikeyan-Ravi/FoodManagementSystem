using FoodManagementSystem.DAL;
using FoodManagementSystem.Entity;
using System.Collections.Generic;

namespace FoodManagementSystem.BL
{
    // interface declaration 
    public interface IFoodBL
    {
        // declaration of methods of 
        // interface that will be implemented  
        // by the class which inherits the interface 
        IEnumerable<FoodItem> GetFoodDetails();
        IEnumerable<FoodCategory> GetFoodCategories();
        void AddFood(FoodItem foodItem);
        IEnumerable<FoodItem> DisplayRestaurantFoods(int id);
        FoodItem GetFoodDetailsById(int id);
        void UpdateFood(FoodItem foodItem);
        void DeleteFood(int foodId);
    }
    public class FoodBL: IFoodBL         //Implementing the interfce
    {
        //creating an Reference of interface
        IFoodItemRepository foodItemRepository;
        public FoodBL()
        {
            // Declare an interface instance
            foodItemRepository = new FoodItemRepository();
        }
        //Retrieves food from all the restaurants
        public IEnumerable<FoodItem> GetFoodDetails()       
        {
            return foodItemRepository.GetFoodDetails();
        }
        //Retrieves food from particular restaurant
        public IEnumerable<FoodItem> DisplayRestaurantFoods(int id)
        {
            return foodItemRepository.DisplayRestaurantFoods(id);
        }
        //Method which Retrieves the food based on id
        public FoodItem GetFoodDetailsById(int id)
        {
            return foodItemRepository.GetFoodDetailsById(id);
        }
        //Retrieves the food categories
        public IEnumerable<FoodCategory> GetFoodCategories()
        {
            return foodItemRepository.GetFoodCategories();
        }
        //Method to Add food to db
        public void AddFood(FoodItem foodItem)
        {
            foodItemRepository.AddFood(foodItem);
        }
        //Method to update the existing food 
        public void UpdateFood(FoodItem foodItem)
        {
            foodItemRepository.UpdateFood(foodItem);
        }
        //Method to delete the food
        public void DeleteFood(int foodId)
        {
            foodItemRepository.DeleteFood(foodId);
        }
    }
}
