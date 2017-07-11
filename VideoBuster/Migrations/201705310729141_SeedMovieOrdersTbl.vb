Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Partial Public Class SeedMovieOrdersTbl
        Inherits DbMigration

        Public Overrides Sub Up()
            Sql("SET IDENTITY_INSERT [dbo].[MovieOrders] ON
INSERT INTO [dbo].[MovieOrders] ([ID], [CustomerID], [MovieID], [Quantity], [DateCheckedOut], [DateCheckedIn]) VALUES (1, 18, 2, 1, N'2017-05-30 00:00:00', NULL)
INSERT INTO [dbo].[MovieOrders] ([ID], [CustomerID], [MovieID], [Quantity], [DateCheckedOut], [DateCheckedIn]) VALUES (2, 18, 3, 1, N'2017-05-30 00:00:00', NULL)
INSERT INTO [dbo].[MovieOrders] ([ID], [CustomerID], [MovieID], [Quantity], [DateCheckedOut], [DateCheckedIn]) VALUES (3, 19, 14, 1, N'2017-04-29 00:00:00', NULL)
SET IDENTITY_INSERT [dbo].[MovieOrders] OFF")
        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
