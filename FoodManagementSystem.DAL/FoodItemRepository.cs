using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.DAL
{
    public class FoodItemRepository
    {
        
        public IEnumerable<FoodCategory> GetFoodCategories()
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                return dbContext.FoodCategories.ToList();
            }
        }
        public void AddFood(FoodItem foodItem)
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                dbContext.FoodItems.Add(foodItem);
                dbContext.SaveChanges();
            }
        }
    }
}
