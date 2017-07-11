Imports VideoBuster.Models

Namespace ViewModels
    Public Class RentalsViewModel

        Private m_Movies As IEnumerable(Of Movie)
        Public Property Movies() As IEnumerable(Of Movie)
            Get
                Return m_Movies
            End Get
            Set(ByVal value As IEnumerable(Of Movie))
                m_Movies = value
            End Set
        End Property

        Private m_Customers As IEnumerable(Of Customer)
        Public Property Customers() As IEnumerable(Of Customer)
            Get
                Return m_Customers
            End Get
            Set(ByVal value As IEnumerable(Of Customer))
                m_Customers = value
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

    End Class

End Namespace
