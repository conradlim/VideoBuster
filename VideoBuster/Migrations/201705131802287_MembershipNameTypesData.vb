Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class MembershipNameTypesData
        Inherits DbMigration

        Public Overrides Sub Up()
            Sql("UPDATE membershipTypes SET membershipName = 'Pay As You Go' WHERE ID = 1 ")
            Sql("UPDATE membershipTypes SET membershipName = 'Monthly' WHERE ID = 2 ")
            Sql("UPDATE membershipTypes SET membershipName = 'Quarterly' WHERE ID = 3 ")
            Sql("UPDATE membershipTypes SET membershipName = 'Annuale' WHERE ID = 4 ")

        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
