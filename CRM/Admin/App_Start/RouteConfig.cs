namespace Crm.Admin
{
	using System.Web.Mvc;
	using System.Web.Routing;

	internal static class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
<<<<<<< HEAD
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
=======
				name: "Authentication",
				url: "login",
				defaults: new { controller = "Authentication", action = "Login" }
			);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "User", action = "List", id = UrlParameter.Optional }
>>>>>>> 7af9fb1ea3b1a3e81293ef60abbc90bb0747ed25
			);
		}
	}
}