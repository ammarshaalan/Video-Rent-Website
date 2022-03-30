namespace vidlko.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'234f2aef-15f7-43ea-a46d-03745e16b0dc', N'guest@vidlko.com', 0, N'ACbm1mrPQsxJMqMSX/H9+EijDEHaM2IyfGKeux0zJEgzckCak6hFHQ+p3trqH5Uw9g==', N'53350576-ae02-4572-a0e5-75b4322f7967', NULL, 0, 0, NULL, 1, 0, N'guest@vidlko.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c2e50be8-2cd5-4826-8cbe-f7c45ee6138e', N'admin@vidlko.com', 0, N'AIWWuT8RcrE0dLDP16L78axsJx6wC1xtzXcdV3JdVxi5UEFlTrnsyeharkkcceIFiA==', N'617ef96a-e332-420c-84c1-4bbd06134ef0', NULL, 0, 0, NULL, 1, 0, N'admin@vidlko.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9587f450-0539-4285-886a-fa1f38c8c560', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c2e50be8-2cd5-4826-8cbe-f7c45ee6138e', N'9587f450-0539-4285-886a-fa1f38c8c560')




");
        
        }
        
        public override void Down()
        {
        }
    }
}
