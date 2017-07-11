Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class dropMovieOrdersTbl
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.MovieOrders", "MovieId", "dbo.Movies")
            DropForeignKey("dbo.MovieOrders", "CustomerId", "dbo.Customers")
            DropIndex("dbo.MovieOrders", New String() {"MovieId"})
            DropIndex("dbo.MovieOrders", New String() {"CustomerId"})
            DropTable("dbo.MovieOrders")

        End Sub
        
        Public Overrides Sub Down()

        End Sub
    End Class
End Namespace
