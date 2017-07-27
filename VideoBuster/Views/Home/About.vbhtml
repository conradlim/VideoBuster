@modeltype VideoBuster.Models.Emails
@Code
    Dim ECount As Integer = 0
    ViewData("Title") = "About"
End Code
<div class="container viewContainer">
    <div class="col-lg-12" style="margin-top:25px;">
        <div class="col-md-6">
            <h1>@ViewData("Title").</h1>
    <h4>Just a dude who love to code.  We analyze our use cases and use the best technological way to create your application</h4>
            <label>Creators/Developers:</label>&nbsp;<span style="color:whitesmoke">Conrad Lim</span><br />
            <label>Email:</label>&nbsp;<span style="color:whitesmoke">c&c@advancedvb.net</span> <br />
            <label>Address:</label>&nbsp;<span style="color:whitesmoke">123 De Bug Ste. MVC Stackoverflow, CA 505404 </span>


        </div>
        <div Class="col-md-6">
            <div style = "margin-left:25px;" >
                <h1>Contact Us</h1>
                @Using Html.BeginForm("Save", "Emails")


                    @Html.ValidationSummary()
                    @<Label Class="form-group">Name:</Label>
                    @Html.TextBoxFor(Function(e) e.Name, "Name", New With {Key .class = "form-control", Key .data_val = "true", Key .data_val_required = "Please Enter Your Name"})
                    @<label class="form-group">Email:</label>
                    @Html.TextBoxFor(Function(e) e.Email, "Email", New With {Key .class = "form-control", Key .data_val = "true", Key .data_val_required = "Please Enter your Email"})
                    @<label class="form-group">Phone Number:</label>
                    @Html.TextBoxFor(Function(e) e.PhoneNumber, "Phone Number", New With {Key .class = "form-control"})
                    @<label class="form-group">Message:</label>
                    @Html.TextAreaFor(Function(e) e.Message, New With {Key .class = "form-control", Key .data_val = "true", Key .data_val_required = "Please Type Your Message"})

                    @<Button id="btnEmail" Class="btn btn-danger" style="margin-top:15px;font-weight:bold">EMAIL</Button>
                    @Html.HiddenFor(Function(e) e.ID)
                    @Html.HiddenFor(Function(e) e.DateReceived, New With {Key .Value = System.DateTime.Now})
                End Using
            </div>

        </div>

    </div>
</div>
