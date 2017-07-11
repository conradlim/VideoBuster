Imports VideoBuster.Models
Namespace ViewModels
    Public Class CustomerDetailsViewModel

        Private m_MembershipTypes As membershipType
        Public Property MembershipTypes() As membershipType
            Get
                Return m_MembershipTypes
            End Get
            Set(ByVal value As membershipType)
                m_MembershipTypes = value
            End Set
        End Property

        Private m_Customer As Customer
        Public Property Customer() As Customer
            Get
                Return m_Customer
            End Get
            Set(ByVal value As Customer)
                m_Customer = value
            End Set
        End Property

        Private m_MOrders As List(Of MovieOrders)
        Public Property MOrders() As List(Of MovieOrders)
            Get
                Return m_MOrders
            End Get
            Set(ByVal value As List(Of MovieOrders))
                m_MOrders = value
            End Set
        End Property


        Private m_MovieOrder As MovieOrders
        Public Property MovieOrder() As MovieOrders
            Get
                Return m_MovieOrder
            End Get
            Set(ByVal value As MovieOrders)
                m_MovieOrder = value
            End Set
        End Property




        'Private m_MovieOrders As IEnumerable(Of MovieOrders)
        'Public Property MovieOrders() As IEnumerable(Of MovieOrders)
        '    Get
        '        Return m_MovieOrders
        '    End Get
        '    Set(ByVal value As IEnumerable(Of MovieOrders))
        '        m_MovieOrders = value
        '    End Set
        'End Property


    End Class
End Namespace

