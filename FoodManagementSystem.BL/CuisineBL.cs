using FoodManagementSystem.DAL;
using FoodManagementSystem.Entity;
using System.Collections.Generic;

namespace FoodManagementSystem.BL
{
    // interface declaration 
    public interface ICuisineBL
    {
        // declaration of methods of 
        // interface that will be implemented  
        // by the class which inherits the interface 
        void AddCuisine(Cuisine cuisine);
        List<Cuisine> GetCuisine();
    }
    public class CuisineBL: ICuisineBL       //Implementing the interfce
    {
        //creating an Reference of interface
        ICuisineRepository cuisineRepository;
        public CuisineBL()
        {
            // Declare an interface instance
            cuisineRepository = new CuisineRepository();
        }
        //Add Cuisine to the database
        public void AddCuisine(Cuisine cuisine)         
        {
            cuisineRepository.AddCuisine(cuisine);
        }
        //Retrieves the cuisine from database
        public List<Cuisine> GetCuisine()
        {
            return cuisineRepository.GetCuisine();
        }
    }
}
