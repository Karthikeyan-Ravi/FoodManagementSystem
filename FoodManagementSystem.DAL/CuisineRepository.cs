using FoodManagementSystem.Entity;
using System.Collections.Generic;
using System.Linq;

namespace FoodManagementSystem.DAL
{
    // interface declaration 
    public interface ICuisineRepository
    {
        // declaration of methods of 
        // interface that will be implemented  
        // by the class which inherits the interface 
        void AddCuisine(Cuisine cuisine);
        List<Cuisine> GetCuisine();
    }
    public class CuisineRepository:ICuisineRepository   //Implementing the interfce
    {
        public void AddCuisine(Cuisine cuisine)     // Method to add Cuisine to DB
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                dbContext.Cuisines.Add(cuisine);
                dbContext.SaveChanges();
            }
        }
        public List<Cuisine> GetCuisine()       //Method to get cuisines from db 
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                return dbContext.Cuisines.ToList();
            }
        }
    }
}
