using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.DAL
{
    public class CuisineRepository
    {
        public void AddCuisine(Cuisine cuisine)
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                dbContext.Cuisines.Add(cuisine);
                dbContext.SaveChanges();
            }
        }
        public List<Cuisine> GetCuisine()
        {
            using (FoodManagementSystemDBContext dbContext = new FoodManagementSystemDBContext())
            {
                return dbContext.Cuisines.ToList();
            }
        }
    }
}
