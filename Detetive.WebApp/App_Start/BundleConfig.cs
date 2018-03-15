using System.Web;
using System.Web.Optimization;

namespace Detetive.WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Scripts/jquery-1.10.2.min.js",
                "~/Scripts/jquery.validate.min.js",
                "~/Scripts/modernizr-2.6.2.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js",
                "~/Scripts/Web_App/detetive.view.index.js"
            ));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css", "~/Content/site.css"));
        }
    }
}
