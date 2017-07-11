Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class updateZipCodeToNullable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AlterColumn("dbo.Customers", "ZipCode", Function(c) c.Int())
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.Customers", "ZipCode", Function(c) c.Int(nullable := False))
        End Sub
    End Class
End Namespace
