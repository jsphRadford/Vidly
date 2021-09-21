namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b98e28fa-3b07-4b57-a36e-a61bae6b0819', N'guest@vidly.com', 0, N'AMbjnb6cawI27oBRr1e6tjBICP04coTv4wxIDVJKz+yPQ5SVu8HwagIF2pox+8Hzvw==', N'033f6340-72fd-4800-aea0-bfc36dc6173f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd3dceab1-f221-4e3c-9ab2-66c293d41625', N'admin@Vidly.com', 0, N'ALhTRNhU6VZh4No91xr8SQNgyv9MaQoycVFK1lLqS4eY/7meCuf0htSyxx3sZ55uTw==', N'70af6326-8880-463b-8559-135262998392', NULL, 0, 0, NULL, 1, 0, N'admin@Vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'58dc6d41-fa80-4c9e-bed3-dc879b9acd27', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd3dceab1-f221-4e3c-9ab2-66c293d41625', N'58dc6d41-fa80-4c9e-bed3-dc879b9acd27')
");
        }
        
        public override void Down()
        {
        }
    }
}
