@imports microsoft.aspnet.identity  

<nav class="navbar navbar-default navbar-fixed-top" role="navigation">
    <div class="container">
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            @Html.ActionLink("VideoBuster", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
        </div>

        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1" style="float:left;">
            <ul class="nav navbar-nav">

                <li>@Html.ActionLink("Customer", "index", "Customers")</li>
                <li>@Html.ActionLink("Movies", "index", "Movies")</li>
                @if Request.IsAuthenticated Then
                    @<li>@Html.ActionLink("New Rental", "NewRental", "Orders")</li>
                End If
                
                <li>@Html.ActionLink("About", "About", "Home")</li>

                @Html.Partial("_LoginPartial")
            </ul>
        </div>
    </div>

</nav>


