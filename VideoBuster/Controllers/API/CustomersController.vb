Imports System.Net
Imports System.Web.Http
Imports VideoBuster.Dtos
Imports VideoBuster.Models
Imports AutoMapper

Namespace API
    Public Class CustomersController
        Inherits ApiController

        Private _context As New ApplicationDbContext
        Public Sub CustomersControllers()
            _context = New ApplicationDbContext
        End Sub

        ' GET /api/customers
        Public Function GetCustomers() As IEnumerable(Of Customer)
            Return _context.customers.ToList()
        End Function


        'Public Function GetCustomers() As IEnumerable(Of CustomerDto)
        '    Return _context.customers.ToList().Select(Mapper.Map(Of Customer, CustomerDto))

        'End Function

        ' GET /api/customers/1
        Public Function GetCustomer(id As Integer) As Customer
            Dim customer = _context.customers.SingleOrDefault(Function(c) c.id = id)

            If customer Is Nothing Then
                Throw New HttpResponseException(HttpStatusCode.NotFound)
            Else
                Return customer

                '  Return Mapper.Map(Of Customer, CustomerDto)(customer)
            End If
        End Function

        ' POST /api/customers
        <HttpPost>
        Public Function CreateCustomer(customer As Customer) As Customer
            If Not ModelState.IsValid Then
                Throw New HttpResponseException(HttpStatusCode.BadRequest)
            Else
                _context.customers.Add(customer)
                _context.SaveChanges()

            End If
            Return customer
        End Function

        ' PUT api/customers/1
        <HttpPut>
        Public Sub UpdateCustomer(id As Integer, customer As Customer)
            If Not ModelState.IsValid Then
                Throw New HttpResponseException(HttpStatusCode.BadRequest)
            Else
                Dim customerInDB = _context.customers.SingleOrDefault(Function(c) c.id = id)
                If customerInDB Is Nothing Then
                    Throw New HttpResponseException(HttpStatusCode.NotFound)
                Else
                    customerInDB.Name = customer.Name
                    customerInDB.Birthdate = customer.Birthdate
                    customerInDB.isSubscribedToNewsletter = customer.isSubscribedToNewsletter
                    customerInDB.MembershipTypeid = customer.MembershipTypeid
                End If
                _context.SaveChanges()
            End If
        End Sub

        'DELETE api/customers/1
        Public Sub DeleteCustomer(id As Integer)
            Dim customerInDB = _context.customers.SingleOrDefault(Function(c) c.id = id)
            If customerInDB Is Nothing Then
                Throw New HttpResponseException(HttpStatusCode.NotFound)
            Else
                _context.customers.Remove(customerInDB)
                _context.SaveChanges()
            End If
        End Sub

    End Class
End Namespace