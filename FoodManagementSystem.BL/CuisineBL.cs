using FoodManagementSystem.DAL;
using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.BL
{
    public class CuisineBL
    {
        public void AddCuisine(Cuisine cuisine)
        {
            CuisineRepository cuisineRepository = new CuisineRepository();
            cuisineRepository.AddCuisine(cuisine);
        }
        public List<Cuisine> GetCuisine()
        {
            CuisineRepository cuisineRepository = new CuisineRepository();
            return cuisineRepository.GetCuisine();
        }
    }
}
