Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddMoreMoviesToDb
        Inherits DbMigration

        Public Overrides Sub Up()
            Sql("INSERT INTO Movies (name,Genre,ReleaseDate,DateAddedtoDb,NumberinStock,MovieGenresID) VALUES ('Terminator','Science Fiction',CAST('1984-10-26' AS DATE),CAST('2017-05-11' AS DATETIME),2,6)")
            Sql("INSERT INTO Movies (name,Genre,ReleaseDate,DateAddedtoDb,NumberinStock,MovieGenresID) VALUES ('Finding Nemo','Kids',CAST('2003-05-03' AS DATE),CAST('2017-05-12' AS DATETIME),6,7)")
            Sql("INSERT INTO Movies (name,Genre,ReleaseDate,DateAddedtoDb,NumberinStock,MovieGenresID) VALUES ('The Notebook','Romance',CAST('2004-06-25' AS DATE),CAST('2017-05-12' AS DATETIME),1,3)")
            Sql("INSERT INTO Movies (name,Genre,ReleaseDate,DateAddedtoDb,NumberinStock,MovieGenresID) VALUES ('Rush Hour','Comedy',CAST('1998-09-18' AS DATE),CAST('2017-05-12' AS DATETIME),2,1)")
            Sql("INSERT INTO Movies (name,Genre,ReleaseDate,DateAddedtoDb,NumberinStock,MovieGenresID) VALUES ('Saving Private Ryan','War',CAST('1998-07-24' AS DATE),CAST('2017-05-12' AS DATETIME),1,4)")
        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
