Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Partial Public Class AddMovieOrdersTbl
        Inherits DbMigration

        Public Overrides Sub Up()
            CreateTable(
                           "dbo.MovieOrders",
                           Function(c) New With
                               {
                                   .ID = c.Int(nullable:=False, identity:=True),
                                   .CustomerId = c.Int(nullable:=False),
                                   .MovieId = c.Int(nullable:=False),
                                   .Quantity = c.Int(nullable:=False),
                                   .DateCheckedOut = c.DateTime(nullable:=False),
                                   .DateCheckedIn = c.DateTime()
                               }) _
                           .PrimaryKey(Function(t) t.ID) _
                           .ForeignKey("dbo.Customers", Function(t) t.CustomerId, cascadeDelete:=True) _
                           .ForeignKey("dbo.Movies", Function(t) t.MovieId, cascadeDelete:=True) _
                           .Index(Function(t) t.CustomerId) _
                           .Index(Function(t) t.MovieId)
        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
