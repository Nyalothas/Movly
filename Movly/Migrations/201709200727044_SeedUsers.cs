namespace Movly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'650f0e35-2f74-4356-8253-a2e186eb07b0', N'guest@movly.com', 0, N'AIT86yGnXAu7tGFY88o91xxKsLHTIQ12cBThaCGfp/QUq9xwkC9IOFvM+BF6qARU+A==', N'cfdce884-db5b-454a-a101-e4927a14d4a6', NULL, 0, 0, NULL, 1, 0, N'guest@movly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9284b39d-02eb-4fc9-84ab-070e12d7b3cc', N'admin@movly.com', 0, N'ABPWGqxfQKrlETvgsm2kDZBExq7QFzvTruplzgqzAGkQVVrFzRthDal8NRQoEyEvYg==', N'463b73e3-96d5-42d5-823b-1fb8dcf04e4a', NULL, 0, 0, NULL, 1, 0, N'admin@movly.com')
            

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'575f88c3-48e0-4e33-bf96-05a9b675b97a', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9284b39d-02eb-4fc9-84ab-070e12d7b3cc', N'575f88c3-48e0-4e33-bf96-05a9b675b97a')
               ");
        }

        public override void Down()
        {
        }
    }
}
