Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddMembershipNameToMembershipType
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.membershipTypes", "MembershipName", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.membershipTypes", "MembershipName")
        End Sub
    End Class
End Namespace
