namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Maxlength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cuisines", "CuisineName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "Mail", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Customers", "ConfirmPassword", c => c.String(nullable: false, maxLength: 12));
            AlterColumn("dbo.Restaurants", "RestaurantName", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Restaurants", "Location", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Restaurants", "RestaurantName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Restaurants", new[] { "RestaurantName" });
            AlterColumn("dbo.Restaurants", "Location", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Restaurants", "RestaurantName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customers", "ConfirmPassword", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "Password", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "Mail", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Cuisines", "CuisineName", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
