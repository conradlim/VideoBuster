Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class ChangeDobDataType
        Inherits DbMigration

        Public Overrides Sub Up()
            Sql("ALTER TABLE Customers ALTER COLUMN Birthdate DATETIME")
        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
