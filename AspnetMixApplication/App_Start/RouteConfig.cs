using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace AspnetMixApplication
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // WebForms routes
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            // MVC routes
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
//            routes.IgnoreRoute("{resource}.aspx/{*pathInfo}");

            routes.MapRoute(
               "Default",
               // Route name
               "mvc/{controller}/{action}/{id}",
               // URL with parameters
               new { controller = "Home", action = "Index", id = "" }
                // Parameter defaults
                );
        }
    }
}
