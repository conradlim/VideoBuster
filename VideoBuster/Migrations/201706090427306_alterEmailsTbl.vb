Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class alterEmailsTbl
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Emails", "DateRead", Function(c) c.DateTime())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Emails", "DateRead")
        End Sub
    End Class
End Namespace
