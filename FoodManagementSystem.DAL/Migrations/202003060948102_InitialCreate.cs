namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodItems",
                c => new
                    {
                        FoodID = c.Int(nullable: false, identity: true),
                        RestaurantID = c.Int(nullable: false),
                        FoodName = c.String(nullable: false),
                        FoodCategory = c.String(nullable: false),
                        FoodPrice = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FoodID)
                .ForeignKey("dbo.RestaurantFields", t => t.RestaurantID, cascadeDelete: true)
                .Index(t => t.RestaurantID);
            
            CreateTable(
                "dbo.RestaurantFields",
                c => new
                    {
                        RestaurantID = c.Int(nullable: false, identity: true),
                        RestaurantName = c.String(nullable: false),
                        RestaurantType = c.String(nullable: false),
                        Location = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RestaurantID);
            
            CreateTable(
                "dbo.CustomerFields",
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodItems", "RestaurantID", "dbo.RestaurantFields");
            DropIndex("dbo.FoodItems", new[] { "RestaurantID" });
            DropTable("dbo.CustomerFields");
            DropTable("dbo.RestaurantFields");
            DropTable("dbo.FoodItems");
        }
    }
}
