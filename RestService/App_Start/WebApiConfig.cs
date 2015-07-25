using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace RestService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            //System.Net.Http.Formatting.JsonMediaTypeFormatter

            //config.Formatters.Clear();
            //config.Formatters.Add(new JsonMediaTypeFormatter());
            //config.Formatters.Add(new FormUrlEncodedMediaTypeFormatter());            

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
