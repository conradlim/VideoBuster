Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddMovieFK1
        Inherits DbMigration

        Public Overrides Sub Up()
            DropForeignKey("dbo.Movies", "MovieGenre_id", "dbo.MovieGenres")
            DropIndex("dbo.Movies", New String() {"MovieGenre_id"})
            DropColumn("dbo.Movies", "MovieGenre_id")
            DropIndex("dbo.Movies", New String() {"MovieGenreID"})
            DropColumn("dbo.Movies", "MovieGenreID")

            AddColumn("dbo.Movies", "MovieGenreID", Function(c) c.Byte(nullable:=False))
            CreateIndex("dbo.Customers", "MovieGenreID")
            AddForeignKey("dbo.Movies", "MovieGenreID", "dbo.MovieGenres", "Id", cascadeDelete:=True)

        End Sub

        Public Overrides Sub Down()

            DropColumn("dbo.Movies", "MovieGenreID")
        End Sub
    End Class
End Namespace
