using FoodManagementSystem.Entity;
using System.Data.Entity;

namespace FoodManagementSystem.DAL
{
    public class FoodManagementSystemDBContext : DbContext
    {
        public FoodManagementSystemDBContext() : base("FoodManagement")
        {

        }
        public DbSet<Customer> Customers        //Property of customer table
        {
            get;
            set;
        }
        public DbSet<Restaurant> Restaurants    //Property of Restaurant table
        {
            get;
            set;
        }
        public DbSet<FoodItem> FoodItems        //Property of FoodItem table
        {
            get;
            set;
        }
        public DbSet<Cuisine> Cuisines          //Property of Cuisine table
        {
            get;
            set;
        }
        //public DbSet<RestaurantCuisine> RestaurantCuisines
        //{
        //    get;
        //    set;
        //}
        public DbSet<FoodCategory> FoodCategories       //Property of FoodCategory table
        {
            get;
            set;
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Restaurant>().MapToStoredProcedures();
        //    modelBuilder.Entity<RestaurantCuisine>().MapToStoredProcedures();
        // }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Restaurant>()
        //        .HasOptional<FoodItem>(s=>s.FoodItem)
        //        .WithMany()
        //        .WillCascadeOnDelete(true);
        //}

    }
}