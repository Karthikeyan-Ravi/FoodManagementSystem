namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RestaurantCuisines",
                c => new
                    {
                        RestaurantCuisineID = c.Int(nullable: false, identity: true),
                        RestaurantID = c.Int(nullable: false),
                        CuisineID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RestaurantCuisineID)
                .ForeignKey("dbo.Cuisines", t => t.CuisineID, cascadeDelete: true)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantID, cascadeDelete: true)
                .Index(t => t.RestaurantID)
                .Index(t => t.CuisineID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RestaurantCuisines", "RestaurantID", "dbo.Restaurants");
            DropForeignKey("dbo.RestaurantCuisines", "CuisineID", "dbo.Cuisines");
            DropIndex("dbo.RestaurantCuisines", new[] { "CuisineID" });
            DropIndex("dbo.RestaurantCuisines", new[] { "RestaurantID" });
            DropTable("dbo.RestaurantCuisines");
        }
    }
}
