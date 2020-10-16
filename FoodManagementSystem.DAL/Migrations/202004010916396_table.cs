namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Cuisines", "CuisineName", unique: true);
            CreateIndex("dbo.Customers", "PhoneNumber", unique: true);
            CreateIndex("dbo.Customers", "Mail", unique: true);
            CreateIndex("dbo.Restaurants", "PhoneNumber", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Restaurants", new[] { "PhoneNumber" });
            DropIndex("dbo.Customers", new[] { "Mail" });
            DropIndex("dbo.Customers", new[] { "PhoneNumber" });
            DropIndex("dbo.Cuisines", new[] { "CuisineName" });
        }
    }
}
