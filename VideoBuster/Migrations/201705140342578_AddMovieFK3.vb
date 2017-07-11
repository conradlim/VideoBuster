Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddMovieFK3
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Movies", "MovieGenresId", Function(c) c.Byte(nullable := False))
            AddColumn("dbo.Movies", "MovieGenres_id", Function(c) c.Int())
            CreateIndex("dbo.Movies", "MovieGenres_id")
            AddForeignKey("dbo.Movies", "MovieGenres_id", "dbo.MovieGenres", "id")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Movies", "MovieGenres_id", "dbo.MovieGenres")
            DropIndex("dbo.Movies", New String() { "MovieGenres_id" })
            DropColumn("dbo.Movies", "MovieGenres_id")
            DropColumn("dbo.Movies", "MovieGenresId")
        End Sub
    End Class
End Namespace
