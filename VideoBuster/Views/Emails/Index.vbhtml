@modeltype   IEnumerable(Of VideoBuster.Models.Emails)

@Code
    ViewData("Title") = "Inbox"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container viewContainer">
    <h2>Inbox</h2>
    <table class="table table-hover" style="opacity:.9">
        <thead style="font-weight:bold">
            <tr>
                <td>Date</td>
                <td>From</td>
                <td>Email</td>
                <td>Message</td>
            </tr>
        </thead>
        <tbody>
            @For Each email In Model
                @<tr>

                    @if email.DateRead Is Nothing Then
                        @<td>
                            @Html.ActionLink(email.DateReceived, "msgDetails", "Emails", New With {.id = email.ID}, New With {.style = "font-weight:bold"})

                        </td>
                        @<td>
                            @Html.ActionLink(email.Name, "msgDetails", "Emails", New With {.id = email.ID}, New With {.style = "font-weight:bold"})

                        </td>
                        @<td>
                            @Html.ActionLink(email.Email, "msgDetails", "Emails", New With {.id = email.ID}, New With {.style = "font-weight:bold"})

                        </td>

                        @<td style="font-weight:bold">

                            @if email.Message.Length > 50 Then
                                Dim longMsg = email.Message
                                Dim shortMsg = longMsg.Substring(0, 50)
                                @(shortMsg & "...")
                            Else
                                @email.Message
                            End If

                        </td>
                        @Html.Hidden("email.Dateread", Date.Now)
                        @(email.DateRead = Date.Now)
                    Else
                        @<td>
                            @Html.ActionLink(email.DateReceived, "msgDetails", "Emails", New With {.id = email.ID}, "")
                        </td>
                        @<td>
                            @Html.ActionLink(email.Name, "msgDetails", "Emails", New With {.id = email.ID}, "")
                        </td>
                        @<td>
                            @Html.ActionLink(email.Email, "msgDetails", "Emails", New With {.id = email.ID}, "")
                        </td>
                        @<td>
                            @if email.Message.Length > 50 Then
                                Dim longMsg = email.Message
                                Dim shortMsg = longMsg.Substring(0, 50)
                                @(shortMsg & "...")
                            Else
                                @email.Message
                            End If

                        </td>
                    End If
                    <td>
                        @Using Html.BeginForm("Delete", "Emails")
                            @Html.Hidden("id.ID", email.ID)
                            @<button data-emails-id="@email.ID" class="btn btn-danger" value="@email.ID">Delete</button>
                        End Using


                    </td>

                </tr>

            Next
        </tbody>
    </table>


</div>
