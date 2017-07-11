Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class removeingfk
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.Movies", "MovieGenres_id", "dbo.MovieGenres")
            DropIndex("dbo.Movies", New String() { "MovieGenres_id" })
            DropColumn("dbo.Movies", "MovieGenresId")
            DropColumn("dbo.Movies", "MovieGenres_id")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Movies", "MovieGenres_id", Function(c) c.Int())
            AddColumn("dbo.Movies", "MovieGenresId", Function(c) c.Byte(nullable := False))
            CreateIndex("dbo.Movies", "MovieGenres_id")
            AddForeignKey("dbo.Movies", "MovieGenres_id", "dbo.MovieGenres", "id")
        End Sub
    End Class
End Namespace
