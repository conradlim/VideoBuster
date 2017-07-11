Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class FillCustomersDOB
        Inherits DbMigration

        Public Overrides Sub Up()
            Sql("UPDATE Customers SET Birthdate = CAST('1980-01-01' AS DATETIME) WHERE Id = 3")
            Sql("UPDATE Customers SET Birthdate = CAST('1980-02-01' AS DATETIME) WHERE Id = 4")
        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
