Imports System.ComponentModel.DataAnnotations
Imports VideoBuster.Models

Namespace Dtos
    Public Class CustomerDto

        Public Property id() As Integer
            Get
                Return cust_id
            End Get
            Set(ByVal value As Integer)
                cust_id = value
            End Set
        End Property
        Private cust_id As Integer

        <Required>
        <StringLength(255)>
        Public Property Name() As String
            Get
                Return cust_Name
            End Get
            Set(ByVal value As String)
                cust_Name = value
            End Set
        End Property
        Private cust_Name As String


        Public Property isSubscribedToNewsletter() As Boolean
            Get
                Return m_isSubscribedToNewsletter
            End Get
            Set(ByVal value As Boolean)
                m_isSubscribedToNewsletter = value
            End Set
        End Property
        Private m_isSubscribedToNewsletter As Boolean

        'foreign key
        Public Property MembershipTypeid() As Byte
            Get
                Return cust_MembershipTypeId
            End Get
            Set(ByVal value As Byte)
                cust_MembershipTypeId = value
            End Set
        End Property
        Private cust_MembershipTypeId As Byte

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
    End Class
End Namespace

