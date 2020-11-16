namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CartEntity : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Carts");
            AddColumn("dbo.Carts", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Carts", "CartId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Carts", "CartId");
            CreateIndex("dbo.Carts", "UserId");
            AddForeignKey("dbo.Carts", "UserId", "dbo.Customers", "UserID", cascadeDelete: true);
            DropColumn("dbo.Carts", "RecordId");
            DropColumn("dbo.Carts", "Count");
            DropColumn("dbo.Carts", "DateCreated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carts", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Carts", "Count", c => c.Int(nullable: false));
            AddColumn("dbo.Carts", "RecordId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Carts", "UserId", "dbo.Customers");
            DropIndex("dbo.Carts", new[] { "UserId" });
            DropPrimaryKey("dbo.Carts");
            AlterColumn("dbo.Carts", "CartId", c => c.String());
            DropColumn("dbo.Carts", "UserId");
            AddPrimaryKey("dbo.Carts", "RecordId");
        }
    }
}
