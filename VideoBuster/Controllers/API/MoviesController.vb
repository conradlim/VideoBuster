Imports System.Net
Imports System.Web.Http
Imports VideoBuster.Models



Namespace Controllers.API
    Public Class MoviesController
        Inherits ApiController

        Private _context As New ApplicationDbContext
        Public Sub CustomersControllers()
            _context = New ApplicationDbContext
        End Sub

        'GET /api/movies
        Public Function GetMovies() As IEnumerable(Of Movie)
            Return _context.Movie.ToList()
        End Function

        Public Function GetMovie(id As Integer) As Movie
            Dim movie = _context.Movie.SingleOrDefault(Function(m) m.id = id)
            If movie Is Nothing Then
                Throw New HttpResponseException(HttpStatusCode.NotFound)
            Else
                Return movie
            End If
        End Function

        Public Sub DeleteMovie(id As Integer)
            Dim movieInDb = _context.Movie.SingleOrDefault(Function(m) m.id = id)
            If movieInDb Is Nothing Then
                Throw New HttpResponseException(HttpStatusCode.NotFound)
            Else
                _context.Movie.Remove(movieInDb)
                _context.SaveChanges()

            End If
        End Sub
    End Class
End Namespace