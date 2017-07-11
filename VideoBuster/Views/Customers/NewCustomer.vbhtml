@modeltype VideoBuster.ViewModels.NewCustomerViewModel
@Code
    ViewData("Title") = "NewCustomer"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<div class="container viewContainer">

    <div class="col-lg-8 col-lg-offset-4">
        <h2>New Customer</h2>
        <fieldset>
            @Using Html.BeginForm("Save", "Customers")
                @Html.ValidationSummary()
                @<div class="form-group">

                    @Html.LabelFor(Function(c) c.Customer.Name, "Name:", New With {Key .[style] = "font-weight:bold"})
                    @Html.TextBoxFor(Function(c) c.Customer.Name, New With {Key .[class] = "form-control", Key .[data_val] = "true", Key .[data_val_required] = "Name is required"})
                </div>
                @<div class="form-group">
                    @Html.LabelFor(Function(c) c.Customer.Email, "Email:", New With {Key .[style] = "font-weight:bold"})
                    @Html.TextBoxFor(Function(c) c.Customer.Email, New With {Key .[class] = "form-control", Key .[data_val] = "true", Key .[data_val_required] = "Email is required"})
                </div>
                @<div class="form-group">
                    @Html.LabelFor(Function(c) c.Customer.StreeAddress, "Address", New With {Key .[style] = "font-weigth:bold", Key .[data_val_required] = "Address is required"})
                    <p>
                        @Html.TextBoxFor(Function(c) c.Customer.StreeAddress, New With {Key .[data_val] = True, Key .[placeholder] = "Street Address", Key .[data_val_required] = "Street address is required"})
                    </p>
                    @Html.TextBoxFor(Function(c) c.Customer.City, New With {Key .[data_val] = True, Key .[placeholder] = "City", Key .[data_val_required] = "City is required", .[style] = "max-width:280px"})

                    @Html.TextBoxFor(Function(c) c.Customer.State, New With {Key .[data_val] = True, Key .[placeholder] = "State", Key .[data_val_required] = "State is required", .[style] = "max-width:100px"})
                    @Html.TextBoxFor(Function(c) c.Customer.ZipCode, New With {Key .[data_val] = True, Key .[placeholder] = "Zip Code", Key .[data_val_required] = "Zip  is required", .[style] = "max-width:75px"})

                </div>
                @<div class="form-group">
                    @Html.LabelFor(Function(c) c.Customer.PhoneNumber, "Phone Number", New With {Key .[style] = "font-weight:bold"})
                    @Html.TextBoxFor(Function(c) c.Customer.PhoneNumber, New With {Key .[class] = "form-control", .[data_val_required] = "Phone number is required"})
                </div>
                @<div class="form-group">

                    @Html.LabelFor(Function(c) c.Customer.MembershipTypeid, "Membership Type:", New With {Key .[style] = "font-weight:bold"})
                    @Html.DropDownListFor(Function(c) c.Customer.MembershipTypeid, New SelectList(Model.MembershipTypes, "Id", "MembershipName"), "Select Membership", New With {Key .[class] = "form-control", Key .[data_val_required] = "Membership Type Required"})

                </div>
                @<div class="form-group">

                    @Html.LabelFor(Function(c) c.Customer.Birthdate, New With {Key .[style] = "font-weight:bold"}):
                    @Html.TextBoxFor(Function(c) c.Customer.Birthdate, "{0:d MMM yyyy}", New With {Key .[class] = "form-control"})
                </div>

                @<div Class="checkbox">
                    <Label>
                        
                        @Html.CheckBoxFor(Function(c) c.Customer.isSubscribedToNewsletter) Subscribed to Newsletter?
                    </Label>
                </div>
                @Html.HiddenFor(Function(c) c.Customer.id)


                @<button type="submit" class="btn btn-primary">SAVE</button>
            End Using
        </fieldset>

    </div>

</div>
@section scripts
    <script>
        $(document).ready(function () {

            $(function () {
                $('#datePicker').datetimepicker({

                });

            });
        })


    </script>
End Section