namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Image : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FoodItems", "FoodImagePath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FoodItems", "FoodImagePath");
        }
    }
}
