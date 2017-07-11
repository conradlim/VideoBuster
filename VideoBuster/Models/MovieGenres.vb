Imports System.ComponentModel.DataAnnotations
Namespace Models

    Public Class MovieGenres
        Private m_id As Integer
        Public Property id() As Integer
            Get
                Return m_id
            End Get
            Set(ByVal value As Integer)
                m_id = value
            End Set
        End Property

        Private m_Genre As String
        Public Property Genre() As String
            Get
                Return m_Genre
            End Get
            Set(ByVal value As String)
                m_Genre = value
            End Set
        End Property

    End Class
End Namespace