Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class removeFK
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.Movies", "MovieGenre_id", "dbo.MovieGenres")
            DropIndex("dbo.Movies", New String() { "MovieGenre_id" })
            DropColumn("dbo.Movies", "MovieGenreId")
            DropColumn("dbo.Movies", "MovieGenre_id")
        End Sub
        
        Public Overrides Sub Down()

        End Sub
    End Class
End Namespace
