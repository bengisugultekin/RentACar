using System.Web.Mvc;
using System.Web.Routing;

namespace RentACar
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default6",
                url: "logout",
                defaults: new { controller = "Login", action = "Logout", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default5",
                url: "panel",
                defaults: new { controller = "Dashboard", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Default4",
                url: "login",
                defaults: new { controller = "Login", action = "SignIn", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default3",
                url: "add-vehicle",
                defaults: new { controller = "Vehicle", action = "Add", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default2",
                url: "list-vehicle",
                defaults: new { controller = "Vehicle", action = "List", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Dashboard", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
