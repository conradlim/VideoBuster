@Imports Microsoft.AspNet.Identity

@code
    Dim email = User.Identity.Name.ToString
    Dim emailSplit = email.Split("@")
    Dim name As String = emailSplit(0).ToUpper
End Code

@If Request.IsAuthenticated Then
    @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm", .class = "navbar-right"})
        @Html.AntiForgeryToken()
        @<ul class="nav navbar-nav navbar-left">
               

            <li>
                
                @Html.ActionLink("Hello " + name + "!", "Index", "Manage", routeValues:=Nothing, htmlAttributes:=New With {.title = "Manage"})

            </li>
            <li><a href="javascript:document.getElementById('logoutForm').submit()">Log off</a></li>
        </ul>
    End Using
Else
    @<ul class="nav navbar-nav navbar-right">
        @*<li>@Html.ActionLink("Register", "Register", "Account", routeValues := Nothing, htmlAttributes := New With { .id = "registerLink" })</li>
        <li>@Html.ActionLink("Log in", "Login", "Account", routeValues := Nothing, htmlAttributes := New With { .id = "loginLink" })</li>*@
    </ul>
End If

