namespace Crm.Admin
{
    using System.Web.Optimization;

	internal static class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
            bundles.Add(
                new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js")
            );

<<<<<<< HEAD
=======
			bundles.Add(
				new ScriptBundle("~/bundles/jqueryval")
				.Include("~/Scripts/jquery.validate.js")
				.Include("~/Scripts/jquery.validate.unobtrusive.js")
			);

>>>>>>> 7af9fb1ea3b1a3e81293ef60abbc90bb0747ed25
            bundles.Add(
                new ScriptBundle("~/bundles/jqueryajax")
                .Include("~/Scripts/jquery.unobtrusive-ajax.js")
            );
<<<<<<< HEAD
=======

			bundles.Add(
				new StyleBundle("~/bundles/site")
				.Include("~/Styles/Site.css")
			);
>>>>>>> 7af9fb1ea3b1a3e81293ef60abbc90bb0747ed25
		}
	}
}