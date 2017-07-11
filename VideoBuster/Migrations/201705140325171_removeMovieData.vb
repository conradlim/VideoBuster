Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class removeMovieData
        Inherits DbMigration

        Public Overrides Sub Up()
            Sql("DELETE from Movies where id=1")
        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
