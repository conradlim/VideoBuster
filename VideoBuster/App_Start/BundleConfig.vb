Imports System.Web.Optimization

Public Module BundleConfig
    ' For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/lib").Include(
                    "~/Scripts/jquery-{version}.js",
                    "~/Scripts/moment.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootbox.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/DataTables/jquery.dataTables.js",
                       "~/Scripts/DataTables/dataTables.bootstrap.js",
                    "~/Scripts/bootstrap-datetimepicker.js"
                    ))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Use the development version of Modernizr to develop with and learn from. Then, when you're
        ' ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))


        bundles.Add(New StyleBundle("~/Content/css").Include(
                  "~/Content/lumen-bootstrap.css",
                  "~/Content/datatables/css/datatables.bootstrap.css",
                  "~/Content/site.css",
                  "~/Content/bootstrap-datetimepicker.css"
        ))
    End Sub
End Module

