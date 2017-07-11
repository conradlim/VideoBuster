Imports System.Web.Http
Imports System.Web.Optimization
Imports AutoMapper
Imports System.Data.Entity
'Imports VideoBuster.App_Start
Imports System.Web.Routing
Imports System.Web.Mvc


Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        '  Mapper.Initialize(Sub(c) c.AddProfile(Of MappingProfile)())
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        AreaRegistration.RegisterAllAreas()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
        'Database.SetInitializer<MyDbContext>(null);
        Database.SetInitializer(Of ApplicationDbContext)(Nothing)
    End Sub
End Class
