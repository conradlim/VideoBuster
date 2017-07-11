Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class seedMovieOrders
        Inherits DbMigration

        Public Overrides Sub Up()

            Sql("  SET IDENTITY_INSERT [dbo].[MovieOrders] ON 
                Insert INTO MovieOrders (Id, CustomerId,MovieId,Quantity,DateCheckedOut) VALUES(4,23,15,1,6/2/2017)
            Insert INTO MovieOrders (Id, CustomerId,MovieId,Quantity,DateCheckedOut) VALUES(5,23,4,1,6/2/2017) 
            Insert INTO MovieOrders (Id, CustomerId,MovieId,Quantity,DateCheckedOut) VALUES(6,1020,15,1,6/1/2017) 
            Insert INTO MovieOrders (Id, CustomerId,MovieId,Quantity,DateCheckedOut) VALUES(7,1020,9,1,6/1/2017) 
            Insert INTO MovieOrders (Id, CustomerId,MovieId,Quantity,DateCheckedOut) VALUES(8,1020,10,1,6/2/2017) 
            SET IDENTITY_INSERT [dbo].[MovieOrders] OFF")

        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
