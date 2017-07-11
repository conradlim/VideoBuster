Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

Public Class WebApiConfig
    Public Shared Sub Register(ByVal config As HttpConfiguration)
        ' Web API configuration and services
        Dim settings = config.Formatters.JsonFormatter.SerializerSettings
        settings.ContractResolver = New CamelCasePropertyNamesContractResolver()
        settings.Formatting = Formatting.Indented


        ' Web API routes
        config.MapHttpAttributeRoutes()

        config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional}
        )
    End Sub
End Class