Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class CreateGenreTbl1
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.MovieGenres",
                Function(c) New With
                    {
                        .id = c.Int(nullable := False, identity := True),
                        .Genre = c.String()
                    }) _
                .PrimaryKey(Function(t) t.id)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.MovieGenres")
        End Sub
    End Class
End Namespace
