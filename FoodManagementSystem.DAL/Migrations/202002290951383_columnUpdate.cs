namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class columnUpdate : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.RestaurantFields");
            AddColumn("dbo.RestaurantFields", "RestaurantID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.RestaurantFields", "RestaurantName", c => c.String(nullable: false));
            AlterColumn("dbo.RestaurantFields", "RestaurantType", c => c.String(nullable: false));
            AlterColumn("dbo.RestaurantFields", "Location", c => c.String(nullable: false));
            AddPrimaryKey("dbo.RestaurantFields", "RestaurantID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.RestaurantFields");
            AlterColumn("dbo.RestaurantFields", "Location", c => c.String());
            AlterColumn("dbo.RestaurantFields", "RestaurantType", c => c.String());
            AlterColumn("dbo.RestaurantFields", "RestaurantName", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.RestaurantFields", "RestaurantID");
            AddPrimaryKey("dbo.RestaurantFields", "RestaurantName");
        }
    }
}
