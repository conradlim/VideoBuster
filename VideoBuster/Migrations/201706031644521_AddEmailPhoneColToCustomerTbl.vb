Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddEmailPhoneColToCustomerTbl
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Customers", "PhoneNumber", Function(c) c.String())
            AddColumn("dbo.Customers", "Email", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Customers", "Email")
            DropColumn("dbo.Customers", "PhoneNumber")
        End Sub
    End Class
End Namespace
