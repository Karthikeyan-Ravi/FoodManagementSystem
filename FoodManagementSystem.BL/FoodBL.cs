﻿using FoodManagementSystem.DAL;
using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.BL
{
    public class FoodBL
    {
        FoodItemRepository foodItemRepository = new FoodItemRepository();
        public IEnumerable<FoodCategory> GetFoodCategories()
        {
            return foodItemRepository.GetFoodCategories();
        }
        public void AddFood(FoodItem foodItem)
        {
            foodItemRepository.AddFood(foodItem);
        }
    }
}
