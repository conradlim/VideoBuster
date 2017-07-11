Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddMovieFK
        Inherits DbMigration

        Public Overrides Sub Up()


            AddColumn("dbo.Movies", "MovieGenresId", Function(c) c.Byte(nullable:=False))

        End Sub

        Public Overrides Sub Down()


            AddColumn("dbo.Movies", "MovieGenresId", Function(c) c.Byte(nullable:=False))

        End Sub
    End Class
End Namespace
