Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class CreateGenreColumns
        Inherits DbMigration

        Public Overrides Sub Up()
            Sql("INSERT INTO MovieGenres (Genre) VALUES ('Comedy')")
            Sql("INSERT INTO MovieGenres (Genre) VALUES ('Action')")
            Sql("INSERT INTO MovieGenres (Genre) VALUES ('Romance')")
            Sql("INSERT INTO MovieGenres (Genre) VALUES ('War')")
            Sql("INSERT INTO MovieGenres (Genre) VALUES ('Adventure')")
            Sql("INSERT INTO MovieGenres (Genre) VALUES ('Science Fiction')")
            Sql("INSERT INTO MovieGenres (Genre) VALUES ('Kids')")

        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
