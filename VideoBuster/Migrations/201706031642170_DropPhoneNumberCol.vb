Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class DropPhoneNumberCol
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropColumn("dbo.Customers", "PhoneNumber")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Customers", "PhoneNumber", Function(c) c.Int(nullable := False))
        End Sub
    End Class
End Namespace
