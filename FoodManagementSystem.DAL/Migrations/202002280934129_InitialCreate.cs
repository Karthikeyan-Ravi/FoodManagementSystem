namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RestaurantFields",
                c => new
                    {
                        RestaurantName = c.String(nullable: false, maxLength: 128),
                        RestaurantType = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.RestaurantName);
            
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
            DropTable("dbo.CustomerFields");
            DropTable("dbo.RestaurantFields");
        }
    }
}
