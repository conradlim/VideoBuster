@modeltype IEnumerable(Of VideoBuster.Models.Movie)
@Code
    ViewData("Title") = "Movie List"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code


<div class="container viewContainer">
    <h2 style="margin-bottom:35px;text-align:center">Movie Lists</h2>

    <table class="table table-hover" id="movie" style="opacity:.9">
        <thead>
            <tr>
                <th>MOVIES</th>
                <th>GENRE</th>
                <th>DELETE</th>


            </tr>
        </thead>
        <tbody>
            @For Each movie In Model
                @<tr>

                    <td>@Html.ActionLink(movie.Name, "Details", "Movies", New With {.id = movie.id}, "")</td>
                    <td>@movie.MovieGenres.Genre</td>

                    <td> <Button Class="btn-link js-delete" data-movies-id="@movie.id">Delete</Button></td>


                </tr>

            Next
        </tbody>
    </table>

    @Html.ActionLink("Add Movie", "NewMovie", "Movies", New With {.class = "btn btn-primary", .style = "margin-top:15px;"})


</div>
@section scripts
    <script>

    $(document).ready(function () {

        $("#movie").DataTable({
            "aLengthMenu": [[10,25, 50, 75, -1], [10,25, 50, 75, "All"]],
            "pageLength": 25
        });
        $('#movie').on("click", ".js-delete", function () {
            var button = $(this);
            bootbox.confirm("Are you sure you want to delete?", function (result) {
                if (result) {
                    $.ajax({
                        url: "api/movies/" + button.attr("data-movies-id"),
                        method: "DELETE",
                        success: function () {
                            button.parents("tr").remove();
                            bootbox.alert("<h3>Movie Deleted</h3>");

                        }
                    })
                }

            })
        })

    })
    </script>
End Section