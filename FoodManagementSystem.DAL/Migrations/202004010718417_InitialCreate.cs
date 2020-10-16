namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cuisines",
                c => new
                    {
                        CuisineID = c.Int(nullable: false, identity: true),
                        CuisineName = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.CuisineID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.Long(nullable: false),
                        Gender = c.Int(nullable: false),
                        Mail = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false, maxLength: 20),
                        ConfirmPassword = c.String(nullable: false, maxLength: 20),
                        Role = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.FoodCategories",
                c => new
                    {
                        FoodCategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 7),
                    })
                .PrimaryKey(t => t.FoodCategoryID);
            
            CreateTable(
                "dbo.FoodItems",
                c => new
                    {
                        FoodID = c.Int(nullable: false, identity: true),
                        RestaurantID = c.Int(nullable: false),
                        FoodName = c.String(nullable: false, maxLength: 20),
                        FoodCategoryID = c.Int(nullable: false),
                        FoodPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FoodID)
                .ForeignKey("dbo.FoodCategories", t => t.FoodCategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantID, cascadeDelete: true)
                .Index(t => t.RestaurantID)
                .Index(t => t.FoodCategoryID);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        RestaurantID = c.Int(nullable: false, identity: true),
                        RestaurantName = c.String(nullable: false, maxLength: 30),
                        Location = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.Long(nullable: false),
                        CuisineID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RestaurantID)
                .ForeignKey("dbo.Cuisines", t => t.CuisineID, cascadeDelete: true)
                .Index(t => t.CuisineID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodItems", "RestaurantID", "dbo.Restaurants");
            DropForeignKey("dbo.Restaurants", "CuisineID", "dbo.Cuisines");
            DropForeignKey("dbo.FoodItems", "FoodCategoryID", "dbo.FoodCategories");
            DropIndex("dbo.Restaurants", new[] { "CuisineID" });
            DropIndex("dbo.FoodItems", new[] { "FoodCategoryID" });
            DropIndex("dbo.FoodItems", new[] { "RestaurantID" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.FoodItems");
            DropTable("dbo.FoodCategories");
            DropTable("dbo.Customers");
            DropTable("dbo.Cuisines");
        }
    }
}
