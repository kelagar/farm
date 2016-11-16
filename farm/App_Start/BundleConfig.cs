using System.Web;
using System.Web.Optimization;

namespace farm
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.intellisense.js",
                        "~/Scripts/jquery-1.10.2.js",
                        "~/Scripts/jquery-1.10.2.min.js",
                        "~/Scripts/jquery-2.1.3-vsdoc.js",
                        "~/Scripts/jquery-2.1.3.js",
                        "~/Scripts/jquery-2.2.3.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate-vsdoc.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.6.2.js"));

            bundles.Add(new ScriptBundle("~/bundles/respond").Include(
                        "~/Script/respond.js",
                         "~/Script/respond.min.js",
                         "~/Script/npm.js"));
            
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/npm.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/respond.min.js",
                      "~/Scripts/Chart.js",
                      "~/Scripts//Chart.min.js",
                      "~/Scripts/app.js",
                      "~/Scripts/app.min.js",
                      "~/Scripts/app.js",
                      "~/Scripts/app.min.js",
                      "~/Scripts/demo.js",
                      "~/Scripts/angular-resource.min"));

            bundles.Add(new ScriptBundle("~/admin-lte/js").Include(
                "~/admin-lte/js/dashboard.js",
                "~/admin-lte/js/dashboard2.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.css",
                      "~/admin-lte/css/AdminLTE.css",
                      "~/admin-lte/css/AdminLTE.min.css",
                      "~/admin-lte/css/skins/_all-skina.css",
                      "~/admin-lte/css/skins/_all-skina.min.css",
                      "~/admin-lte/css/skins/skin-green.css",
                      "~/admin-lte/css/skins/skin-green.min.css",
                      "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/fonts").Include(
                     "~/Content/bootstrap-theme.css",
                     "~/Content/bootstrap-theme.min.css",
                     "~/Content/bootstrap.css",
                     "~/Content/bootstrap.min.css"
                     ));
                        
        }
    }
}
