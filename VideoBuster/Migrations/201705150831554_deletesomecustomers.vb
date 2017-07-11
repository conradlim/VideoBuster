Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class deletesomecustomers
        Inherits DbMigration

        Public Overrides Sub Up()
            Sql("Delete from Customers where id IN (3,4)")
        End Sub


        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
