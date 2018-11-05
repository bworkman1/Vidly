namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'68fce4b4-6f78-4df5-8e7e-9f5386088ffa', N'employee@vidly.com', 0, N'AF5ZmCka6/AgaGzBVh7eW/5h2f+bVJPqJMPxWiW9w8uKkfLwI9MQochW+IYp9iHNiA==', N'8b26a31e-3286-4705-af84-22a0bc7e1af3', NULL, 0, 0, NULL, 1, 0, N'employee@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fb485133-36a8-4d2a-832c-2b218b21e1b0', N'manager@vidly.com', 0, N'AH5Yp7H22I/3gNdnoykLuuKE3cTEVjHOOORJRd79uwVKKJNsDkt9fr09fEIBMIKDbQ==', N'11cdbebc-d0bb-4a69-8786-cce1f694def6', NULL, 0, 0, NULL, 1, 0, N'manager@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df42bcfa-e594-434c-8ae0-0553ee8d8372', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fb485133-36a8-4d2a-832c-2b218b21e1b0', N'df42bcfa-e594-434c-8ae0-0553ee8d8372')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
