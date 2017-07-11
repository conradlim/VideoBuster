@Code
    ViewData("Title") = "Home Page"
End Code

<header id="myCarousel" class="carousel slide"> 
    <!-- Indicators -->
    <ol class="carousel-indicators">
        <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
        <li data-target="#myCarousel" data-slide-to="1"></li>
        <li data-target="#myCarousel" data-slide-to="2"></li>
    </ol>

    <!-- Wrapper for Slides -->
    <div class="carousel-inner">
        <div class="item active">
            <img src="~/Content/jpgs/index2.jpg" alt="Alternate Text" class="fill" />
            <div class="carousel-caption">
                @*<h2>Caption 1</h2>*@
            </div>
        </div>
        <div class="item">
                    <img src="~/Content/jpgs/Wonder-WomanA2.jpg" class="fill"/>
                    <div class="carousel-caption">
                        @*<h2>Caption 2</h2>*@
                    </div>
                </div>
                <div class="item">
        <img src="~/Content/jpgs/toyStory2.jpg" class="fill" />
        <div class="carousel-caption">
            @*<h2>Caption 3</h2>*@
        </div>
    </div>
    </div>



    <!-- Controls -->
    <a class="left carousel-control" href="#myCarousel" data-slide="prev">
        <span class="icon-prev"></span>
    </a>
    <a class="right carousel-control" href="#myCarousel" data-slide="next">
        <span class="icon-next"></span>
    </a>
 </header>
<div class="container" id="jumboHeader">
    <div class="row">

        <div class="col-lg-6 col-sm-12">
            <h1 class="navbar-brand">The Big Picture</h1>
            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Magni, iusto, unde, sunt incidunt id sapiente rerum soluta voluptate harum veniam fuga odit ea pariatur vel eaque sint sequi tenetur eligendi.</p>


            @Html.ActionLink("Register", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink", .class = "btn btn-danger"})
            @Html.ActionLink("Log in", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "loginLink", .class = "btn btn-danger"})
        </div>

    </div>
</div>
<!-- Page Content -->  
<section>
    <div class="container middleRow">
        <div class="row">

                <div class="col-lg-4">
                    <h2><i class="fa fa-stop-circle fa-2x" aria-hidden="true"></i></h2>
                    <h2 style="font-size:18px;"><strong>No commitments. Cancel Anytime</strong></h2>
                    <p>If you decide VideoBuster isn't for you - no problem. No commitment. Cancel online anytime.</p>
                </div>
                <div class="col-lg-4">
                    <h2>
                        <i class="fa fa-truck fa-2x" aria-hidden="true"></i>
                    </h2>
                    <h2 style="font-size:18px;"><strong>Free Shipping & Return</strong></h2>
                    <p>
                        We partnered with every single courier in the nation that we are able to offer <strong>FREE</strong> shipping.  If that's not enough even when you return your rental it's <strong><u>FREE</u></strong>
                    </p>
                </div>
                <div class="col-lg-4">
                    <h2><i class="fa fa-usd fa-2x" aria-hidden="true"></i></h2>
                    <h2 style="font-size:18px;"><strong>Discounts For Power Renters</strong></h2>
                    <p>What's even better in addition to our free shipping?  That you can save even more with our 4-tiered membership. The more you rent, the more you save!  Check out our rates.</p>
                </div>
       
        </div>
    </div>
</section>





