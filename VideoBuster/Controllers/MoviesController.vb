Imports System.Web.Mvc
'added vbuster model 
Imports VideoBuster.Models
Imports System.Data.Entity
Imports VideoBuster.ViewModels

Namespace VideoBuster.Controllers
    Public Class MoviesController
        Inherits Controller

        Private _context As New ApplicationDbContext

        Public Sub moviesController()
            Dim _context As New ApplicationDbContext
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            _context.Dispose()
        End Sub

        ' GET: Movies
        <AllowAnonymous>
        Function index() As ViewResult

            Dim movie = _context.Movie.Include(Function(m) m.MovieGenres)
            Return View(movie)
        End Function


        Public Function ReadOnlyIndex() As ActionResult
            Return View()
        End Function

        Function Edit(id As Integer) As ActionResult
            Return Content("id = " & id)
        End Function

        Public Function NewMovie() As ActionResult
            Dim GenreTypes = _context.Genres.ToList()
            Dim viewModel = New NewMovieViewModel() With {.MovieGenres = GenreTypes}
            Return View("NewMovie", viewModel)
        End Function

        <HttpPost>
        Public Function Save(Movie As Movie) As ActionResult
            Movie.DateAddedToDb = DateTime.Now()
            _context.Movie.Add(Movie)
            _context.SaveChanges()
            Return RedirectToAction("Index", "Movies")
        End Function

        <AllowAnonymous>
        Function Details(id As Integer) As ActionResult
            Dim movies = _context.Movie.Include(Function(c) c.MovieGenres).SingleOrDefault(Function(m) m.id = id)
            If movies Is Nothing Then
                Return HttpNotFound()
            End If
            Return View(movies)
        End Function

        <Route("movies/released/{year}/{month:regex(\d{2}):range(1,12)}")>
        Public Function ByReleaseDate(year As Integer, month As Integer) As ActionResult

            Return Content(year & "/" & month)
        End Function
    End Class
End Namespace