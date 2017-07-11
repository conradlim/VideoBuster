Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddMembershipType
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.membershipTypes",
                Function(c) New With
                    {
                        .Id = c.Byte(nullable := False),
                        .SignUpFee = c.Short(nullable := False),
                        .DurationInMonths = c.Byte(nullable := False),
                        .DiscountRate = c.Byte(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Id)
            
            AddColumn("dbo.Customers", "MembershipTypeId", Function(c) c.Byte(nullable := False))
            CreateIndex("dbo.Customers", "MembershipTypeId")
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.membershipTypes", "Id", cascadeDelete := True)
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.membershipTypes")
            DropIndex("dbo.Customers", New String() { "MembershipTypeId" })
            DropColumn("dbo.Customers", "MembershipTypeId")
            DropTable("dbo.membershipTypes")
        End Sub
    End Class
End Namespace
