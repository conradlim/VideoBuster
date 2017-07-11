@modeltype VideoBuster.ViewModels.RandomMovieViewModel
@Code
    ViewData("Title") = "Random"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

@Code   

    Dim className As String
    If Model.customers.Count < 5 Then
        className = "popular"
    Else
        className = ""
    End If
End Code


<h2>Random</h2>

@If Model.customers.Count = 0 Then
    @<p>
     No one has rented this movie before.
    </p>
End If
<ul>

        @For Each movie In Model.Movie
            @<li>
             @movie.name
            </li>
        Next

    
</ul>

