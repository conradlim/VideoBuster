@modelType VideoBuster.ViewModels.NewMovieViewModel
@Code
    ViewData("Title") = "New Movie"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<header id="myCarousel" class="carousel slide">
    <div class="carousel-inner">
        <div class="item active">
            <img src="~/Content/jpgs/star-wars-posters-pic.jpg" alt="Alternate Text" class="fill" />


        </div>
    </div>
</header>
<div class="container" style="margin-top:-900px;">
    <div class="col-lg-8 col-lg-offset-4">
        <h2>Add New Movie</h2>
        <fieldset>
            @Using Html.BeginForm("Save", "Movies")

                @<div Class="form-group">
                    @Html.LabelFor(Function(m) m.Movie.Name, New With {Key .[style] = "font-weight:bold"})
                    @Html.TextBoxFor(Function(m) m.Movie.Name, New With {Key .[class] = "form-control", .[required] = "required"})
                </div>
                @<div class="form-group">
                    @Html.LabelFor(Function(m) m.Movie.ReleaseDate, "Release Date:", New With {Key .[style] = "font-weight:bold"})
                    @Html.TextBoxFor(Function(m) m.Movie.ReleaseDate, New With {Key .[class] = "form-control", .[required] = "required"})
                </div>
                        @<div class="form-group">
                            @Html.LabelFor(Function(m) m.Movie.Genre, "Genre:", New With {Key .[style] = "font-weight:bold"})
                            @Html.DropDownListFor(Function(m) m.Movie.MovieGenresID, New SelectList(Model.MovieGenres, "Id", "Genre"), "", New With {Key .[class] = "form-control", .[required] = "required"})
                        </div>
                        @<div class="form-group">
                            @Html.LabelFor(Function(m) m.Movie.NumberInStock, "Number In Stock:", New With {Key .[style] = "font-weight:bold"})
                            @Html.TextBoxFor(Function(m) m.Movie.NumberInStock, New With {Key .[class] = "form-control", .[required] = "required"})
                        </div>
                        @<div class="form-group">
                            @Html.LabelFor(Function(m) m.Movie.MoviePoster, "Movie Poster File:", New With {Key .[style] = "font-weight:bold"})
                            @Html.TextBoxFor(Function(m) m.Movie.MoviePoster, New With {Key .[class] = "form-control"})
                            @Html.HiddenFor(Function(m) m.Movie.DateAddedToDb, New With {Key .Value = DateTime.Now})
        </div>
                        @<button type="submit" Class="btn btn-primary" style="margin-top:25px;">Submit</button>
            End Using
        </fieldset>
    </div>


</div>
