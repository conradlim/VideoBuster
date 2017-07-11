Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddBirthdateCol
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Customers", "Birthdate", Function(c) c.DateTime())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Customers", "Birthdate")
        End Sub
    End Class
End Namespace
