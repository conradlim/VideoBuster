Imports VideoBuster.Models

Namespace ViewModels

    Public Class NewMovieViewModel
        Private m_MovieGenres As IEnumerable(Of MovieGenres)
        Public Property MovieGenres() As IEnumerable(Of MovieGenres)
            Get
                Return m_MovieGenres
            End Get
            Set(ByVal value As IEnumerable(Of MovieGenres))
                m_MovieGenres = value
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
    End Class

End Namespace

