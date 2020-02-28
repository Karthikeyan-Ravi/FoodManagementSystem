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
        public DbSet<CustomerFields> User
        {
            get;
            set;
        }
        public DbSet<RestaurantFields> Restaurant
        {
            get;
            set;
        }
    }
}
