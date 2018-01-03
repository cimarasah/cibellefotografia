using System.Web;
using System.Web.Optimization;

namespace cs.cibellefotografia
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/detalhes.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));




            /*Templete Regna Master*/
            bundles.Add(new ScriptBundle("~/bundles/regna-master/jquery").Include(
                         "~/Scripts/regna-master/jquery-migrate.min.js",
                     "~/Scripts/regna-master/jquery.min.js" ));

            bundles.Add(new ScriptBundle("~/bundles/regna-master").Include(
                     "~/Scripts/regna-master/bootstrap.bundle.min.js",
                     "~/Scripts/regna-master/bootstrap.min.js",
                     "~/Scripts/regna-master/contactform.js",
                     "~/Scripts/regna-master/counterup.min.js",
                     "~/Scripts/regna-master/easing.js",
                     "~/Scripts/regna-master/easing.min.js",
                     "~/Scripts/regna-master/hoverIntent.js",             
                     "~/Scripts/regna-master/main.js",
                     "~/Scripts/regna-master/superfish.js",
                     "~/Scripts/regna-master/superfish.min.js",
                     "~/Scripts/regna-master/waypoints.min.js",
                     "~/Scripts/regna-master/wow.js",
                     "~/Scripts/regna-master/wow.min.js"));

            bundles.Add(new StyleBundle("~/Content/regna-master/css").Include(
                     "~/Content/regna-master/animate.css",
                     "~/Content/regna-master/animate.min.css",
                     "~/Content/regna-master/bootstrap.css",
                     "~/Content/regna-master/bootstrap.min.css",
                     "~/Content/regna-master/font-awesome.css",
                     "~/Content/regna-master/font-awesome.min.css",
                     "~/Content/regna-master/style.css"));

            /*Fim do templete*/
        }
    }
}
