Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class addMoviePosterJpgs
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Movies", "MoviePoster", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Movies", "MoviePoster")
        End Sub
    End Class
End Namespace
