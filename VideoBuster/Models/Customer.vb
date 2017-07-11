Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Customer

        Private cust_id As Integer
        Public Property id() As Integer
            Get
                Return cust_id
            End Get
            Set(ByVal value As Integer)
                cust_id = value
            End Set
        End Property

        <Required(ErrorMessage:="Please Enter Your Name")>
        <StringLength(255)>
        Private cust_Name As String
        Public Property Name() As String
            Get
                Return cust_Name
            End Get
            Set(ByVal value As String)
                cust_Name = value
            End Set
        End Property

        Private m_isSubscribedToNewsletter As Boolean
        Public Property isSubscribedToNewsletter() As Boolean
            Get
                Return m_isSubscribedToNewsletter
            End Get
            Set(ByVal value As Boolean)
                m_isSubscribedToNewsletter = value
            End Set
        End Property

        Private cust_MembershipType As membershipType
        Public Property MembershipType() As membershipType
            Get
                Return cust_MembershipType
            End Get
            Set(ByVal value As membershipType)
                cust_MembershipType = value
            End Set
        End Property

        'foreign key
        Private cust_MembershipTypeId As Byte
        Public Property MembershipTypeid() As Byte
            Get
                Return cust_MembershipTypeId
            End Get
            Set(ByVal value As Byte)
                cust_MembershipTypeId = value
            End Set
        End Property

        <Display(Name:="Date of Birth")>
        <Min18YearsIfAMember>
        Public Property Birthdate() As System.Nullable(Of DateTime)
            Get
                Return m_Birthdate
            End Get
            Set
                m_Birthdate = Value
            End Set
        End Property
        Private m_Birthdate As System.Nullable(Of DateTime)

        <Required(ErrorMessage:="Please Enter Street Address")>
        Private m_StreetAddress As String
        Public Property StreeAddress() As String
            Get
                Return m_StreetAddress
            End Get
            Set(ByVal value As String)
                m_StreetAddress = value
            End Set
        End Property
        <Required(ErrorMessage:="Please Enter City")>
        Private m_City As String
        Public Property City() As String
            Get
                Return m_City
            End Get
            Set(ByVal value As String)
                m_City = value
            End Set
        End Property

        <Required(ErrorMessage:="Please Enter State")>
        <MaxLength(2)>
        Private m_State As String
        Public Property State() As String
            Get
                Return m_State
            End Get
            Set(ByVal value As String)
                m_State = value
            End Set
        End Property



        Private m_ZipCode As System.Nullable(Of Integer)
        Public Property ZipCode() As System.Nullable(Of Integer)
            Get
                Return m_ZipCode
            End Get
            Set(ByVal value As System.Nullable(Of Integer))
                m_ZipCode = value
            End Set
        End Property

        <Required>
        <RegularExpression("^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")>
        Private m_PhoneNumber As String
        Public Property PhoneNumber() As String
            Get
                Return m_PhoneNumber
            End Get
            Set(ByVal value As String)
                m_PhoneNumber = value
            End Set
        End Property

        Private m_Email As String
        Public Property Email() As String
            Get
                Return m_Email
            End Get
            Set(ByVal value As String)
                m_Email = value
            End Set
        End Property
    End Class

End Namespace