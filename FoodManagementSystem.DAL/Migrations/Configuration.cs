﻿namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FoodManagementSystem.DAL.FoodManagementSystemDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FoodManagementSystem.DAL.FoodManagementSystemDBContext";
        }

        protected override void Seed(FoodManagementSystem.DAL.FoodManagementSystemDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
