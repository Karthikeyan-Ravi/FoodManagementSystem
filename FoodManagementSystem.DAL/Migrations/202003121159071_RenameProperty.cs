namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FoodItems", "FoodCategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.FoodItems", "FoodCategoryID");
            AddForeignKey("dbo.FoodItems", "FoodCategoryID", "dbo.FoodCategories", "FoodCategoryID", cascadeDelete: true);
            DropColumn("dbo.FoodItems", "FoodCategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodItems", "FoodCategory", c => c.String(nullable: false));
            DropForeignKey("dbo.FoodItems", "FoodCategoryID", "dbo.FoodCategories");
            DropIndex("dbo.FoodItems", new[] { "FoodCategoryID" });
            DropColumn("dbo.FoodItems", "FoodCategoryID");
        }
    }
}
