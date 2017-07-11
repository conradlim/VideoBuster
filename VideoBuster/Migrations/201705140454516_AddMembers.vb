Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddMembers
        Inherits DbMigration

        Public Overrides Sub Up()
            Sql("INSERT INTO Customers (name,isSubscribedToNewsletter,MembershipTypeId) VALUES ('Zane Christopher','False',4)")
            Sql("INSERT INTO Customers (name,isSubscribedToNewsletter,MembershipTypeId,Birthdate) VALUES ('Charlie Pierson','True',3,CAST('1980-10-02' AS DATE))")
        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
