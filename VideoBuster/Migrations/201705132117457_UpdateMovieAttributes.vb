Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class UpdateMovieAttributes
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Movies", "Genre", Function(c) c.String())
            AddColumn("dbo.Movies", "ReleaseDate", Function(c) c.DateTime(nullable := False))
            AddColumn("dbo.Movies", "DateAddedToDb", Function(c) c.DateTime(nullable := False))
            AddColumn("dbo.Movies", "NumberInStock", Function(c) c.Byte(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Movies", "NumberInStock")
            DropColumn("dbo.Movies", "DateAddedToDb")
            DropColumn("dbo.Movies", "ReleaseDate")
            DropColumn("dbo.Movies", "Genre")
        End Sub
    End Class
End Namespace
