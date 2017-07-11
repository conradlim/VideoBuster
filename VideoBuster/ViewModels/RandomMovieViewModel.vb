Imports VideoBuster.Models

Namespace ViewModels
    Public Class RandomMovieViewModel

        Private m_movie As List(Of Movie)
        Public Property Movie() As List(Of Movie)
            Get
                Return m_movie
            End Get
            Set(ByVal value As List(Of Movie))
                m_movie = value
            End Set
        End Property

        Private m_customers As List(Of Customer)
        Public Property customers() As List(Of Customer)
            Get
                Return m_customers
            End Get
            Set(ByVal value As List(Of Customer))
                m_customers = value
            End Set
        End Property

    End Class
End Namespace
