﻿Imports VideoBuster.Models
Namespace ViewModels
    Public Class CustomerDetailsVM
        Private m_MembershipTypes As IEnumerable(Of membershipType)
        Public Property MembershipTypes() As IEnumerable(Of membershipType)
            Get
                Return m_MembershipTypes
            End Get
            Set(ByVal value As IEnumerable(Of membershipType))
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

        Private m_MovieOrders As IEnumerable(Of MovieOrders)
        Public Property MovieOrders() As IEnumerable(Of MovieOrders)
            Get
                Return m_MovieOrders
            End Get
            Set(ByVal value As IEnumerable(Of MovieOrders))
                m_MovieOrders = value
            End Set
        End Property

    End Class

End Namespace