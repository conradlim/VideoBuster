@ModelType VideoBuster.ViewModels.RentalsViewModel
@Code
    ViewData("Title") = "NewRental"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code


<div class="container viewContainer">
    <div class="col-lg-8 col-lg-offset-4">
        <h2>New Rental</h2>

        @Using Html.BeginForm("CheckedOut", "Orders")
            @<div Class="form-group">
                
                <label>Select Customer:</label>
                 
                @Html.DropDownListFor(Function(c) c.MovieOrder.CustomerId, New SelectList(Model.Customers, "Id", "Name"), "Select Customer", New With {Key .class = "form-control", Key .[data_val] = "true", .[data_val_required] = "Please Select A Customer"})
                
            </div>
                    @<div Class="form-group">
                        @Html.LabelFor(Function(c) c.Movies, "Movies List", New With {Key .[style] = "font-weight:bold"})
                        @Html.DropDownListFor(Function(c) c.MovieOrder.MovieId, New MultiSelectList(Model.Movies, "id", "Name"), "Select Movie", New With {Key .class = "form-control", Key .data_val = "true", Key .data_val_required = "Please Select A Movie"})
        
                    </div>
                    @<div class="form-group">
                        @Html.LabelFor(Function(c) c.MovieOrder.DateCheckedOut, "Check Out Date", New With {Key .style = "font-weight:bold"})
                        @Html.TextBoxFor(Function(c) c.MovieOrder.DateCheckedOut, New With {Key .class = "form-control", Key .data_val = "true"})
                    </div>
                    @<button type="submit" class="btn btn-primary">Submit</button>


                    @Html.HiddenFor(Function(c) c.MovieOrder.ID)
                    @Html.HiddenFor(Function(c) c.MovieOrder.Quantity, New With {Key .Value = 1})

        End Using

    </div>
</div>
