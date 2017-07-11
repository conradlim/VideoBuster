Namespace Models


    Public Class membershipType

        Private m_Id As Byte
        Public Property Id() As Byte
            Get
                Return m_Id
            End Get
            Set(ByVal value As Byte)
                m_Id = value
            End Set
        End Property

        Private m_SignUpFee As Short
        Public Property SignUpFee() As Short
            Get
                Return m_SignUpFee
            End Get
            Set(ByVal value As Short)
                m_SignUpFee = value
            End Set
        End Property

        Private m_DurationInMonths As Byte
        Public Property DurationInMonths() As Byte
            Get
                Return m_DurationInMonths
            End Get
            Set(ByVal value As Byte)
                m_DurationInMonths = value
            End Set
        End Property

        Private m_DiscountRate As Byte
        Public Property DiscountRate() As Byte
            Get
                Return m_DiscountRate
            End Get
            Set(ByVal value As Byte)
                m_DiscountRate = value
            End Set
        End Property

        Private m_MembershipName As String
        Public Property MembershipName() As String
            Get
                Return m_MembershipName
            End Get
            Set(ByVal value As String)
                m_MembershipName = value
            End Set
        End Property


    End Class
End Namespace