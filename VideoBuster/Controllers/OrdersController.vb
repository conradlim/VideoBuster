Imports System.Web.Mvc
Imports System.Data.Entity
Imports VideoBuster.Models
Imports VideoBuster.ViewModels

Namespace Controllers
    Public Class OrdersController
        Inherits Controller


        Private _context As New ApplicationDbContext

        Public Sub ordersController()
            Dim _context = New ApplicationDbContext
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)

            _context.Dispose()

        End Sub

        <HttpPost>
        Public Function CheckedIn(MovieOrder As MovieOrders) As ActionResult
            Dim checkMovieIn = _context.MovieOrders.Single(Function(m) m.ID = MovieOrder.ID)

            checkMovieIn.DateCheckedIn = MovieOrder.DateCheckedIn
            _context.SaveChanges()

            Return Redirect(Request.UrlReferrer.PathAndQuery)
        End Function

        Function NewRental() As ActionResult
            Dim CustomerList = _context.customers.ToList()
            Dim MovieList = _context.Movie.ToList()

            Dim viewModel = New RentalsViewModel() With {.Customers = CustomerList, .Movies = MovieList, .MovieOrder = New MovieOrders}

            Return View("NewRental", viewModel)
        End Function



        <HttpPost>
        Public Function CheckedOut(MovieOrder As MovieOrders) As ActionResult
            If MovieOrder.ID.Equals(Nothing) Then
                _context.MovieOrders.Add(MovieOrder)
            End If
            _context.SaveChanges()

            Dim CustomersRental = _context.customers.Single(Function(c) c.id = MovieOrder.CustomerId)
            Dim customerID = CustomersRental.id

            'Return RedirectToAction("Index", "Customers")
            Return RedirectToAction("customerDetails", "Customers", New With {.id = customerID})

        End Function


    End Class
End Namespace