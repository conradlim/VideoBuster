Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class CreateNewEmailTbl
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Emails",
                Function(c) New With
                    {
                        .ID = c.Int(nullable:=False, identity:=True),
                        .Name = c.String(nullable:=False),
                        .Email = c.String(nullable:=False),
                        .PhoneNumber = c.String(),
                        .Message = c.String(nullable:=False),
                        .DateReceived = c.DateTime(nullable:=False),
                        .DateRespond = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.ID)

        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Emails")
        End Sub
    End Class
End Namespace
