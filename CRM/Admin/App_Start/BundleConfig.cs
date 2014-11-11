﻿namespace Crm.Admin
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

            bundles.Add(
                new ScriptBundle("~/bundles/jqueryajax")
                .Include("~/Scripts/jquery.unobtrusive-ajax.js")
            );
		}
	}
}