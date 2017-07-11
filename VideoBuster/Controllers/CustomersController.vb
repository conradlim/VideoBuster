Imports System.ComponentModel
Imports System.Web.Mvc
Imports VideoBuster.Models
Imports System.Data.Entity
Imports VideoBuster.ViewModels
'Imports System.Collections.Generic
'Imports System.Linq

Namespace Controllers

    Public Class CustomersController
        Inherits Controller

        Private _context As New ApplicationDbContext

        Public Sub customersController()
            Dim _context = New ApplicationDbContext
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)

            _context.Dispose()

        End Sub

        ' GET: Customers

        Public Function index() As ViewResult
            'GET from database
            Dim customers = _context.customers.Include(Function(m) m.MembershipType)
            Return View(customers)
        End Function

        Function customerDetails(id As Integer) As ActionResult
            Dim customer = _context.customers.Include(Function(c) c.MembershipType).SingleOrDefault(Function(c) c.id = id)
            Dim movies = _context.MovieOrders.Include(Function(c) c.Movie)
            Dim movielist = movies.ToList()
            Dim viewModel = New CustomerDetailsViewModel With {.MOrders = movielist, .Customer = customer}

            If customer Is Nothing Then
                Return HttpNotFound()
            End If
            Return View(viewModel)
        End Function

        Function Details(id As Integer) As ActionResult
            'Dim customer = _context.customers.SingleOrDefault(Function(c) c.id = id)
            Dim customer = _context.customers.Include(Function(c) c.MembershipType).SingleOrDefault(Function(c) c.id = id)


            If customer Is Nothing Then
                Return HttpNotFound()
            End If
            Return View(customer)
        End Function

        Public Function Edit(id As Integer) As ActionResult
            Dim customer = _context.customers.SingleOrDefault(Function(c) c.id = id)
            If customer Is Nothing Then
                Return HttpNotFound()
            Else
                Dim viewModel = New NewCustomerViewModel() With {.Customer = customer, .MembershipTypes = _context.MembershipTypes.ToList()}
                Return View("NewCustomer", viewModel)
            End If
        End Function

        Public Function NewCustomer() As ActionResult
            Dim membershipTypes = _context.MembershipTypes.ToList()

            Dim viewModel = New NewCustomerViewModel() With {.Customer = New Customer, .MembershipTypes = membershipTypes}

            Return View("NewCustomer", viewModel)
        End Function


        <HttpPost>
        Public Function Save(Customer As Customer) As ActionResult
            If Not ModelState.IsValid Then
                Dim viewModel = New NewCustomerViewModel() With {.Customer = Customer, .MembershipTypes = _context.MembershipTypes.ToList()}

                Return View("NewCustomer", viewModel)
            End If
            If Customer.id.Equals(Nothing) Then
                _context.customers.Add(Customer)

            Else

                'Grab customer from DB first then make changes
                Dim customerInDb = _context.customers.Single(Function(c) c.id = Customer.id)


                customerInDb.Name = Customer.Name
                customerInDb.Birthdate = Customer.Birthdate
                customerInDb.MembershipTypeid = Customer.MembershipTypeid
                customerInDb.isSubscribedToNewsletter = Customer.isSubscribedToNewsletter
                customerInDb.Email = Customer.Email
                customerInDb.PhoneNumber = Customer.PhoneNumber
                customerInDb.StreeAddress = Customer.StreeAddress
                customerInDb.City = Customer.City
                customerInDb.State = Customer.State
                customerInDb.ZipCode = Customer.ZipCode
            End If

            _context.SaveChanges()
            Return RedirectToAction("customerDetails", "Customers", New With {.id = Customer.id})
        End Function

    End Class
End Namespace