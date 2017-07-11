Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddGenresFK
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Movies", "MovieGenresID", Function(c) c.Int(nullable := False))
            CreateIndex("dbo.Movies", "MovieGenresID")
            AddForeignKey("dbo.Movies", "MovieGenresID", "dbo.MovieGenres", "id", cascadeDelete := True)
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Movies", "MovieGenresID", "dbo.MovieGenres")
            DropIndex("dbo.Movies", New String() { "MovieGenresID" })
            DropColumn("dbo.Movies", "MovieGenresID")
        End Sub
    End Class
End Namespace
