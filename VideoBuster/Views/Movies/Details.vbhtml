@modeltype VideoBuster.Models.Movie
@Code
    ViewData("Title") = "Movie Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container viewContainer">
    <h2>@Model.Name</h2>

    <div class="row">
        <div class="col-md-6">
            <ul class="list-group">
                <li class="list-group-item">
                    <p><strong>Movie Genre:</strong>&nbsp;@Model.MovieGenres.Genre</p>
                    <p><strong>Release Date:</strong>&nbsp;@Model.ReleaseDate.DayOfWeek, &nbsp; @Model.ReleaseDate.ToShortDateString()</p>
                    <p><strong>Date Added To Database:</strong>&nbsp;@Model.DateAddedToDb</p>
                    <p><strong>Number In Stock: </strong>&nbsp;@Model.NumberInStock</p>

                </li>
            </ul>
        </div>
        <div class="col-md-6">
            

            @If Model.MoviePoster IsNot Nothing Then
            @<img src = "/Content/posterJpgs/@Url.Content(Model.MoviePoster)" style="width:400px;"/>
             Else
               @<img src="/Content/posterJpgs/no-photo.png" style="width:400px;" />
            End If
            
        </div>
        </div>
</div>