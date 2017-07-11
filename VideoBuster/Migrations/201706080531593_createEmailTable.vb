Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class createEmailTable
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Emails",
                Function(c) New With
                    {
                        .ID = c.Int(nullable:=False, identity:=True),
                        .FromEmail = c.String(nullable:=False),
                        .PhoneNumber = c.String(),
                        .EmailMessage = c.String(nullable:=False),
                        .DateReceived = c.DateTime(nullable:=False)
                    }) _
                .PrimaryKey(Function(t) t.ID)

        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Emails")
        End Sub
    End Class
End Namespace
