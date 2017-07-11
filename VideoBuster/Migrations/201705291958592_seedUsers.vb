Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Partial Public Class seedUsers
        Inherits DbMigration

        Public Overrides Sub Up()
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8b88a26e-6d32-4605-9fb5-adac9657baab', N'guest@videobuster.com', 0, N'AMqK7UVB8FTVSh3pIa6YHn/L/1QbO7YURn6RrPN4C3CSOqs46XZkg41d2xoedIzGIw==', N'10cd2f3f-b729-4058-bb27-564263cc386a', NULL, 0, 0, NULL, 1, 0, N'guest@videobuster.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9e2fee81-5ce7-4116-bc14-4b0cf8588ca7', N'cpierce@videbuster.com', 0, N'AAyrsnkU0oEibwEaF6hGwwzj448PYuRe+5euaJO2E0vlqtCdmQdFxUfYOylcAo8Juw==', N'045035d2-842c-466a-992b-38b4fe7a74e0', NULL, 0, 0, NULL, 1, 0, N'cpierce@videbuster.com')
")

            Sql("INSERT INTO [dbo].[AspNetRoles] ([id], [name]) VALUES (N'c217ef0f-cca3-41da-9664-9a2753b7747b', N'CanManageMovie')
")

            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9e2fee81-5ce7-4116-bc14-4b0cf8588ca7', N'c217ef0f-cca3-41da-9664-9a2753b7747b')
")
        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
