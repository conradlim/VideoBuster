Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddADataToMovieTbl
        Inherits DbMigration

        Public Overrides Sub Up()
            Sql("INSERT INTO Movies (name,Genre,ReleaseDate,DateAddedtoDb,NumberinStock,MovieGenresID) VALUES ('Independence Day','Science Fiction',CAST('1996-06-02' AS DATE),CAST('2017-05-11' AS DATETIME),5,6)")
        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
