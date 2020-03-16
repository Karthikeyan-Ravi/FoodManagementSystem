using FoodManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementSystem.DAL
{
    public class FoodManagementSystemDBContext : DbContext
    {
        public FoodManagementSystemDBContext() : base("FoodManagement")
        {

        }
        public DbSet<Customer> Customers
        {
            get;
            set;
        }
        public DbSet<Restaurant> Restaurants
        {
            get;
            set;
        }
        public DbSet<FoodItem> FoodItems
        {
            get;
            set;
        }
        public DbSet<Cuisine> Cuisines
        {
            get;
            set;
        }
        //public DbSet<RestaurantCuisine> RestaurantCuisines
        //{
        //    get;
        //    set;
        //}
        public DbSet<FoodCategory> FoodCategories
        {
            get;
            set;
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Restaurant>().MapToStoredProcedures();
        //    modelBuilder.Entity<RestaurantCuisine>().MapToStoredProcedures();
        // }

    }
}