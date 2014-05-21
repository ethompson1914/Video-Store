using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.UI;

namespace Web_Interface
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name:"MovieDetails",
            //    url:"{controller}/{action}/{id}",
            //    defaults:new {action="MovieDetails"}
            //    );

            routes.MapRoute(
                name: "ListingByGenre",
                url: "Movies/ByGenre/{name}",
                defaults: new {controller="Movies", action="ByGenre", name=""}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}