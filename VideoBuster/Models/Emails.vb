Namespace Models
    Public Class Emails

        Private m_ID As Integer
        Public Property ID() As Integer
            Get
                Return m_ID
            End Get
            Set(ByVal value As Integer)
                m_ID = value
            End Set
        End Property


        Private e_Name As String
        Public Property Name() As String
            Get
                Return e_Name
            End Get
            Set(ByVal value As String)
                e_Name = value
            End Set
        End Property

        Private e_Email As String
        Public Property Email() As String
            Get
                Return e_Email
            End Get
            Set(ByVal value As String)
                e_Email = value
            End Set
        End Property


        Private e_PhoneNumber As String
        Public Property PhoneNumber() As String
            Get
                Return e_PhoneNumber
            End Get
            Set(ByVal value As String)
                e_PhoneNumber = value
            End Set
        End Property

        Private e_Message As String
        Public Property Message() As String
            Get
                Return e_Message
            End Get
            Set(ByVal value As String)
                e_Message = value
            End Set
        End Property

        Private e_DateReceived As DateTime
        Public Property DateReceived() As DateTime
            Get
                Return e_DateReceived
            End Get
            Set(ByVal value As DateTime)
                e_DateReceived = value
            End Set
        End Property

        Private e_DateRespond As System.Nullable(Of DateTime)
        Public Property DateRespond() As System.Nullable(Of DateTime)
            Get
                Return e_DateRespond
            End Get
            Set(ByVal value As System.Nullable(Of DateTime))
                e_DateRespond = value
            End Set
        End Property

        Private e_DateRead As System.Nullable(Of DateTime)
        Public Property DateRead() As System.Nullable(Of DateTime)
            Get
                Return e_DateRead
            End Get
            Set(ByVal value As System.Nullable(Of DateTime))
                e_DateRead = value
            End Set
        End Property

        Private e_Emailz As IEnumerable(Of Emails)
        Public Property Emailz() As IEnumerable(Of Emails)
            Get
                Return e_Emailz
            End Get
            Set(ByVal value As IEnumerable(Of Emails))
                e_Emailz = value
            End Set
        End Property

    End Class

End Namespace
