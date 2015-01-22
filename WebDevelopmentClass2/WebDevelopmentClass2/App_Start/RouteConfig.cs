using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebDevelopmentClass2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MinMaxDemo",
                url: "Lessons/MinMaxDemo",
                defaults: new { controller = "Lessons", action = "MinMaxDemo" }
            );

            routes.MapRoute(
                name: "CenteredContentDemo",
                url: "Lessons/CenteredContentDemo",
                defaults: new { controller = "Lessons", action = "CenteredContentDemo" }
            );

            routes.MapRoute(
                name: "FixedPositioningDemo",
                url: "Lessons/FixedPositioningDemo",
                defaults: new { controller = "Lessons", action = "FixedPositioningDemo" }
            );

            routes.MapRoute(
                name: "ClearFloatDemo",
                url: "Lessons/ClearFloatDemo",
                defaults: new { controller = "Lessons", action = "ClearFloatDemo" }
            );

            routes.MapRoute(
                name: "Lessons",
                url: "Lessons/{id}",
                defaults: new { controller = "Lessons", action = "Index" }
            );
            
            routes.MapRoute(
                name: "JavaScript Lessons",
                url: "JavaScriptLessons/{id}",
                defaults: new { controller = "JavaScriptLessons", action = "Index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
