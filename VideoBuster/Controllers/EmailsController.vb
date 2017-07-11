Imports System.Web.Mvc
Imports VideoBuster.Models
Imports System.Data.Entity
Imports VideoBuster.ViewModels

Namespace Controllers
    Public Class EmailsController
        Inherits Controller
        Private _context As New ApplicationDbContext

        Public Sub ManageController()
            Dim _context = New ApplicationDbContext
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            _context.Dispose()
        End Sub

        ' GET: Emails
        Function Index() As ActionResult
            Dim emailList = _context.Emails
            Return View(emaillist)
        End Function

        <AllowAnonymous>
        <HttpPost>
        Function Save(Emails As Emails) As ActionResult
            If Emails.ID.Equals(Nothing) Then
                _context.Emails.Add(Emails)
                _context.SaveChanges()

            End If
            Return RedirectToAction("ThankYou", "Emails")
        End Function

        <HttpPost, ActionName("Delete")>
        Function Delete(id As Emails) As ActionResult

            If id.ID.Equals(Nothing) Then
                Return HttpNotFound()
            End If
            Dim emailID = _context.Emails.Single(Function(c) c.ID = id.ID)
            'Dim email As Emails = _context.Emails.Find(id)
            _context.Emails.Remove(emailID)
            _context.SaveChanges()
            Return RedirectToAction("Index", "Emails")
        End Function

        Function msgDetails(id As Integer) As ActionResult
            Dim message = _context.Emails.Single(Function(c) c.ID = id)
            If message Is Nothing Then
                Return HttpNotFound()
            End If
            message.DateRead = Date.Now
            _context.SaveChanges()

            Return View(message)
        End Function

        <AllowAnonymous>
        Function ThankYou() As ActionResult
            Return View()
        End Function
    End Class
End Namespace