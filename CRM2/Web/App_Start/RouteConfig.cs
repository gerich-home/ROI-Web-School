using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                    name: "Client",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Client", action = "Index", id = UrlParameter.Optional }
                    );
            routes.MapRoute(
                name: "HomeAssistant",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "HomeAssistant", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "ClientAssistant",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "ClientAssistant", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "EditAssistant",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "EditAssistant", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "CallsAssistant",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "CallsAssistant", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
              name: "ContactAssistant",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "ContactAssistant", action = "Index", id = UrlParameter.Optional }
              );

            routes.MapRoute(
              name: "Contact",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional }
              );

            routes.MapRoute(
              name: "Calls",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Calls", action = "Index", id = UrlParameter.Optional }
              );

            routes.MapRoute(
              name: "Edit",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Edit", action = "Index", id = UrlParameter.Optional }
              );

            routes.MapRoute(
                name: "Web",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Web", action = "Index", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "WebAssistant",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "WebAssistant", action = "Index", id = UrlParameter.Optional }
                );
        }
    }
}