@modelType IEnumerable(Of VideoBuster.Models.Customer)

@Code
    ViewData("Title") = "Customers"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container viewContainer">
    <h2 style="margin-bottom:35px;text-align:center">Customers</h2>
   
    <table class="table table-hover" id="customers" style="margin-top:15px;opacity:.9">
        <thead>
            <tr>
                <th>Name</th>
                <th>Membership Type</th>
                <th>Discount Rate</th>
                <th>Delete</th>
            </tr>
        </thead>
        <tbody>
            @For Each customer In Model
                @<tr>
                    <td> @Html.ActionLink(customer.Name, "customerDetails", "Customers", New With {.id = customer.id}, "")</td>
                    <td> @customer.MembershipType.MembershipName</td>
                    <td> @customer.MembershipType.DiscountRate%</td>
                    <td>
                        <button class="btn-link js-delete" data-customer-id="@customer.id">Delete</button>
                    </td>
                </tr>
            Next
        </tbody>
    </table>

    @Html.ActionLink("Add Customer", "NewCustomer", "Customers", "", New With {.class = "btn btn-default", .style = "margin-top:15px;"})
</div>

@section scripts
<script>
    $(document).ready(function () {
        $("#customers").DataTable({
            "aLengthMenu": [[25, 50, 75, -1], [25, 50, 75, "All"]],
            "pageLength": 25
        });

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
        });
</script>
End Section




