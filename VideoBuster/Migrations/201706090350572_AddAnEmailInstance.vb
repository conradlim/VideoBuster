Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddAnEmailInstance
        Inherits DbMigration

        Public Overrides Sub Up()
            Sql("SET IDENTITY_INSERT [dbo].[Emails] ON
INSERT INTO [dbo].[Emails] ([ID], [Name], [Email], [PhoneNumber], [Message], [DateReceived], [DateRespond]) VALUES (1, N'Justin Tradeau', N'justin.tradeau@canadapm.gov', NULL, N'Hello..Wonderful Site', N'2017-06-08 00:00:00', NULL)
SET IDENTITY_INSERT [dbo].[Emails] OFF
")
        End Sub

        Public Overrides Sub Down()
        End Sub
    End Class
End Namespace
