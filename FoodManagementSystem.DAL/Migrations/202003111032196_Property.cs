namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Property : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Restaurants", "Cuisines");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurants", "Cuisines", c => c.String(nullable: false));
        }
    }
}
