Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class dropEmailtable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropTable("dbo.Emails")
        End Sub
        
        Public Overrides Sub Down()

        End Sub
    End Class
End Namespace
