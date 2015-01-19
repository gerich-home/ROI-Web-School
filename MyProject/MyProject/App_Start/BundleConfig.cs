using System.Web.Optimization;

namespace MyProject
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
           
            bundles.Add(
                new ScriptBundle("~/Scripts/js")
                .Include("~/Scripts/jquery.validate.unobtrusive.bootstrap.js")
                );
            bundles.Add(
                new StyleBundle("~/Styles/css")
                    .Include("~//Styles/bootstrap.css",
                        "~/Styles/bootstrap-theme.css",
                        "~/Styles/bootstrap.min.css",
                        "~/Styles/bootstrap-theme.min.css",
                        "~/Styles/bootstrap-responsive.css"));
            }
    }
}