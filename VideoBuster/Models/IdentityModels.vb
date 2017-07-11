Imports System.Data.Entity
Imports System.Security.Claims
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports VideoBuster.Models

' You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
Public Class ApplicationUser
    Inherits IdentityUser
    Public Async Function GenerateUserIdentityAsync(manager As UserManager(Of ApplicationUser)) As Task(Of ClaimsIdentity)
        ' Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
        Dim userIdentity = Await manager.CreateIdentityAsync(Me, DefaultAuthenticationTypes.ApplicationCookie)
        ' Add custom user claims here
        Return userIdentity
    End Function
End Class

Public Class ApplicationDbContext
    Inherits IdentityDbContext(Of ApplicationUser)

    Private m_Emails As DbSet(Of Emails)
    Public Property Emails() As DbSet(Of Emails)
        Get
            Return m_Emails
        End Get
        Set(ByVal value As DbSet(Of Emails))
            m_Emails = value
        End Set
    End Property

    Private m_MovieOrders As DbSet(Of MovieOrders)
    Public Property MovieOrders() As DbSet(Of MovieOrders)
        Get
            Return m_MovieOrders
        End Get
        Set(ByVal value As DbSet(Of MovieOrders))
            m_MovieOrders = value
        End Set
    End Property

    Private m_MembershipTypes As DbSet(Of membershipType)
    Public Property MembershipTypes() As DbSet(Of membershipType)
        Get
            Return m_MembershipTypes
        End Get
        Set(ByVal value As DbSet(Of membershipType))
            m_MembershipTypes = value
        End Set
    End Property

    Private m_Genres As DbSet(Of MovieGenres)
    Public Property Genres() As DbSet(Of MovieGenres)
        Get
            Return m_Genres
        End Get
        Set(ByVal value As DbSet(Of MovieGenres))
            m_Genres = value
        End Set
    End Property

    Private m_movies As DbSet(Of Movie)
    Public Property Movie() As DbSet(Of Movie)
        Get
            Return m_movies
        End Get
        Set(ByVal value As DbSet(Of Movie))
            m_movies = value
        End Set
    End Property

    Private m_customers As DbSet(Of Customer)
    Public Property customers() As DbSet(Of Customer)
        Get
            Return m_customers
        End Get
        Set(ByVal value As DbSet(Of Customer))
            m_customers = value
        End Set
    End Property


    Public Sub New()
        MyBase.New("DefaultConnection", throwIfV1Schema:=False)
    End Sub

    Public Shared Function Create() As ApplicationDbContext
        Return New ApplicationDbContext()
    End Function
End Class
