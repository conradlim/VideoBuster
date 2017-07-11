Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddisSubscribedToNewsletter
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Customers", "isSubscribedToNewsletter", Function(c) c.Boolean(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Customers", "isSubscribedToNewsletter")
        End Sub
    End Class
End Namespace
