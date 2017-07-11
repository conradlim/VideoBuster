@modeltype VideoBuster.Models.Emails

@Code
    ViewData("Title") = "Message Details "
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<style>
    .list-group-item {
        margin-top: 50px;
    }

        .list-group-item.msg {
            margin-top: 10px;
            max-width: 75%;
            min-height: 50%;
            background-color: #2a2f36;
            opacity: 1;
        }
</style>
<div class="container viewContainer">
    <h3>Message From: @Model.Name</h3>
    <div class="row" style="margin-top:-40px">
        <div class="col-md-12">
            <ul class="list-group">
                <li class="list-group-item" style="opacity:.9;max-width:50%;">
                    <p><strong>Name:</strong> &nbsp; @Model.Name</p>
                    <p><strong>Email Address:</strong> &nbsp; @Model.Email  </p>
                    <p><strong>Phone Number:</strong> &nbsp; @Model.PhoneNumber</p>
                    <p><strong>Date Received:</strong> &nbsp; @Model.DateReceived</p>

                </li>
            </ul>
            <strong>Message:</strong>
            <ul class="list-group" id="msg">

                <li class="list-group-item msg" style="text-align:center">
                    <p> &nbsp; @Model.Message</p>
                </li>
            </ul>
            @Html.ActionLink("<< Go Back", "Index", "Emails")
        </div>
    </div>
</div>

