Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Populatemembershiptype
        Inherits DbMigration

        Public Overrides Sub Up()

            Sql("INSERT INTO membershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) VALUES(2,30,1,10)")
            Sql("INSERT INTO membershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) VALUES(3,90,3,15)")
            Sql("INSERT INTO membershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) VALUES(4,300,12,20)")
        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
