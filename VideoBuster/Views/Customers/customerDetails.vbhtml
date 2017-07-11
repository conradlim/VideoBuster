@modeltype  VideoBuster.ViewModels.CustomerDetailsViewModel
@Code
    ViewData("Title") = "Customer Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"


End Code

<div class="container viewContainer">
    <h2>@ViewData("Title")</h2>

    <div class="row" style="margin-top:-40px;margin-bottom:75px ;">
        <div class="col-md-6">
            <ul class="list-group">

                <li class="list-group-item" style="opacity:1">
                    <p><strong>Name : </strong> @Model.Customer.Name</p>
                    <p><strong>Membership Type:</strong> @Model.Customer.MembershipType.MembershipName</p>
                    <p><strong>Birthdate:</strong> @Model.Customer.Birthdate.Value.ToShortDateString  </p>
                    
                    <p><strong>Phone Number: &nbsp;</strong>@Model.Customer.PhoneNumber <p>
                    <p><strong>Email: &nbsp;</strong>@Model.Customer.Email</p>                    
                    <p><strong>Address: </strong>@Model.Customer.StreeAddress &nbsp;                 
                   @Model.Customer.City,&nbsp; @Model.Customer.State &nbsp; @Model.Customer.ZipCode </p>   
                </li>
            </ul>
            @Html.ActionLink("EDIT CUSTOMER", "Edit", New With {.id = Model.Customer.id}, New With {.class = "btn btn-primary"})
        </div>      
    </div>
   
    <table class="table table-hover" id="historyTable" style="opacity:1;">
        <thead>
            <tr>
                <th>
                    Movie
                </th>
                <th>
                    Checked-Out
                </th>
                <th>
                    Checked-In
                </th>
                <th>

                </th>
            </tr>
        </thead>
        <tbody>
            @For Each orders In Model.MOrders
                @if Model.Customer.id = orders.CustomerId Then
                    @<tr>
                        <td>@Html.ActionLink(orders.Movie.Name, "Details", "Movies", New With {.id = orders.Movie.id}, "")</td>
                @If orders.DateCheckedOut.AddDays(3) < Date.Now And orders.DateCheckedIn Is Nothing Then
                        @<td style="color:#e74b4b">@orders.DateCheckedOut</td>
                Else
                    @<td>@orders.DateCheckedOut</td>
                End If          

                        <td>@orders.DateCheckedIn</td>                        
                        @If orders.DateCheckedIn Is Nothing Then
                            @using html.BeginForm("CheckedIn", "Orders")
                                @<td>
                                    @Html.HiddenFor(Function(m) m.MovieOrder.ID, New With {.[Value] = orders.ID})
                                    @Html.HiddenFor(Function(m) m.MovieOrder.DateCheckedIn, New With {.[Value] = DateTime.Now})
                                    <button class="btn btn-warning btn-sm" >Check Video In</button>
                                </td>

                            End Using
                        End If

                    </tr>


                End If
            Next
        </tbody>

    </table>
</div>


@section scripts
    <script>

        $(document).ready(function () {

            $("#historyTable").DataTable();
        })
    </script>
End Section


