namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cuisines",
                c => new
                    {
                        CuisineID = c.Int(nullable: false, identity: true),
                        CuisineName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CuisineID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        PhoneNumber = c.Long(nullable: false),
                        Gender = c.Int(nullable: false),
                        Mail = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Role = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.FoodItems",
                c => new
                    {
                        FoodID = c.Int(nullable: false, identity: true),
                        RestaurantID = c.Int(nullable: false),
                        FoodName = c.String(nullable: false),
                        FoodCategory = c.String(nullable: false),
                        FoodPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FoodID)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantID, cascadeDelete: true)
                .Index(t => t.RestaurantID);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        RestaurantID = c.Int(nullable: false, identity: true),
                        RestaurantName = c.String(),
                        Cuisines = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        PhoneNumber = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.RestaurantID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodItems", "RestaurantID", "dbo.Restaurants");
            DropIndex("dbo.FoodItems", new[] { "RestaurantID" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.FoodItems");
            DropTable("dbo.Customers");
            DropTable("dbo.Cuisines");
        }
    }
}
