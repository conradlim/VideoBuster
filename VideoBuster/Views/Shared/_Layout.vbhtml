<!DOCTYPE html>
<html lang="en" xml:lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <script src="https://use.fontawesome.com/3cbc2edc1b.js"></script>
    <link rel="icon" href="~/Content/jpgs/vlogo_ScW_icon.ico" type="image/x-icon" />
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->


</head>
<body>
    @Html.Partial("_NavBar")

    <div class="body-content">
        @RenderBody()
        <footer>
            <hr>
            <section>
                <div class="container" style="margin-bottom:10px;">
                    <ul class="">
                        <li><a href="#"><i class="fa fa-facebook-square fa-3x" aria-hidden="true"></i></a></li>
                        <li><a href="#"><i class="fa fa-instagram fa-3x" aria-hidden="true"></i></a></li>
                        <li><a href="#"><i class="fa fa-twitter-square fa-3x" aria-hidden="true"></i></a></li>

                    </ul>
                </div>
            </section>
            <p>&copy; @DateTime.Now.Year - AVB-Project CLIM CPIERCE</p>
        </footer>

    </div>

    @*//Third party libraries*@
    @Scripts.Render("~/bundles/lib")
    @RenderSection("scripts", required:=False)

    <script src="@Url.Content("~/Scripts/jquery.validate.min.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js")" type="text/javascript"></script>

    <script>

  @*  $(document).ready(function () {
        $("#customers").DataTable();
        $("#movie").DataTable();
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
        $('#customers').on("click", ".js-delete", function () {
            var button = $(this);
            bootbox.confirm("Are you sure you want to delete?", function (result) {
                if (result) {
                    $.ajax({
                        url: "api/customers/" + button.attr("data-customer-id"),
                        method: "DELETE",
                        success: function () {
                            button.parents("tr").remove();
                            bootbox.alert("<h3>Customer Deleted</h3>");
                        }
                    });
                }
            });
        });
    });*@

        $('.carousel').carousel({
            interval: 4000 //changes the speed
        });

    </script>


</body>
</html>
