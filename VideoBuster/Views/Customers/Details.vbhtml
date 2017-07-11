@modeltype VideoBuster.Models.Customer
@*@modeltype  VideoBuster.ViewModels.CustomerDetailsViewModel*@
@Code
    ViewData("Title") = Model.Name
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container viewContainer">
    <h2>@ViewData("Title")</h2>


    <ul class="list-group">
        <li class="list-group-item">

            <p><strong>Membership Type:</strong> &nbsp; @Model.MembershipType.MembershipName</p>

            <p><strong>Subscribed To Newsletter: </strong> &nbsp;@Model.isSubscribedToNewsletter</p>

            @If Model.Birthdate.HasValue Then
                @<p>
                    <strong>Date Of Birth: &nbsp; </strong>
                    @Model.Birthdate
                </p>End If
        </li>

    </ul>
    @Html.ActionLink("EDIT CUSTOMER", "Edit", New With {.id = Model.id}, New With {.class = "btn btn-primary"})

    <table class="table table-hover" id="historyTable" style="margin-top:50px;">
        <thead>
            <tr>
                <th>
                    Movies
                </th>
                <th>
                    Checked Out
                </th>
                <th>
                    Checked In
                </th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
</div>

