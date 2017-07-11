Namespace Models
    Public Class MovieOrders
        Private m_ID As Integer
        Public Property ID() As Integer
            Get
                Return m_ID
            End Get
            Set(ByVal value As Integer)
                m_ID = value
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

        Private m_CustomerId As Integer
        Public Property CustomerId() As Integer
            Get
                Return m_CustomerId
            End Get
            Set(ByVal value As Integer)
                m_CustomerId = value
            End Set
        End Property


        Private m_Movie As Movie
        Public Property Movie() As Movie
            Get
                Return m_Movie
            End Get
            Set(ByVal value As Movie)
                m_Movie = value
            End Set
        End Property

        Private m_MovieId As Integer
        Public Property MovieId() As Integer
            Get
                Return m_MovieId
            End Get
            Set(ByVal value As Integer)
                m_MovieId = value
            End Set
        End Property

        Private m_Quantity As Integer
        Public Property Quantity() As Integer
            Get
                Return m_Quantity
            End Get
            Set(ByVal value As Integer)
                m_Quantity = value
            End Set
        End Property

        Private m_DateCheckedOut As DateTime = DateTime.MinValue
        Public Property DateCheckedOut() As DateTime
            Get
                Return If((m_DateCheckedOut = DateTime.MinValue), DateTime.Now(), m_DateCheckedOut)
            End Get
            Set
                m_DateCheckedOut = Value
            End Set
        End Property

        Private m_DateCheckedIn As System.Nullable(Of DateTime)
        Public Property DateCheckedIn() As Date?
            Get
                Return m_DateCheckedIn
            End Get
            Set
                m_DateCheckedIn = Value
            End Set
        End Property




    End Class

End Namespace
