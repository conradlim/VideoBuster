Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class resetMovie
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.Movies", "MovieGenre_id", "dbo.MovieGenres")
            DropIndex("dbo.Movies", New String() { "MovieGenre_id" })
            DropColumn("dbo.Movies", "MovieGenreID")
            DropColumn("dbo.Movies", "MovieGenre_id")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Movies", "MovieGenre_id", Function(c) c.Int())
            AddColumn("dbo.Movies", "MovieGenreID", Function(c) c.Byte(nullable := False))
            CreateIndex("dbo.Movies", "MovieGenre_id")
            AddForeignKey("dbo.Movies", "MovieGenre_id", "dbo.MovieGenres", "id")
        End Sub
    End Class
End Namespace
