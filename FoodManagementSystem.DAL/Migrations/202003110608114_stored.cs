namespace FoodManagementSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stored : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.sp_InsertCustomer",
                p => new
                    {
                        FullName = p.String(),
                        PhoneNumber = p.Long(),
                        Gender = p.Int(),
                        Mail = p.String(),
                        Password = p.String(),
                        Role = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Customers]([FullName], [PhoneNumber], [Gender], [Mail], [Password], [Role])
                      VALUES (@FullName, @PhoneNumber, @Gender, @Mail, @Password, @Role)
                      
                      DECLARE @UserID int
                      SELECT @UserID = [UserID]
                      FROM [dbo].[Customers]
                      WHERE @@ROWCOUNT > 0 AND [UserID] = scope_identity()
                      
                      SELECT t0.[UserID]
                      FROM [dbo].[Customers] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[UserID] = @UserID"
            );
            
            CreateStoredProcedure(
                "dbo.sp_UpdateCustomer",
                p => new
                    {
                        UserID = p.Int(),
                        FullName = p.String(),
                        PhoneNumber = p.Long(),
                        Gender = p.Int(),
                        Mail = p.String(),
                        Password = p.String(),
                        Role = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Customers]
                      SET [FullName] = @FullName, [PhoneNumber] = @PhoneNumber, [Gender] = @Gender, [Mail] = @Mail, [Password] = @Password, [Role] = @Role
                      WHERE ([UserID] = @UserID)"
            );
            
            CreateStoredProcedure(
                "dbo.sp_DeleteCustomer",
                p => new
                    {
                        UserID = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Customers]
                      WHERE ([UserID] = @UserID)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.sp_DeleteCustomer");
            DropStoredProcedure("dbo.sp_UpdateCustomer");
            DropStoredProcedure("dbo.sp_InsertCustomer");
        }
    }
}
