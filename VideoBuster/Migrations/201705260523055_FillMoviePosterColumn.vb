Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class FillMoviePosterColumn
        Inherits DbMigration

        Public Overrides Sub Up()
            Sql("UPDATE Movies SET MoviePoster = '~\Content\posterJpgs\finding-nemo.jpg' WHERE Id = 4")
            Sql("UPDATE Movies SET MoviePoster = '~\Content\posterJpgs\independence-day.jpg' WHERE Id = 2")
        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
