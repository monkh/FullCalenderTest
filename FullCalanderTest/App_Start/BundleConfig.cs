using System.Web;
using System.Web.Optimization;

namespace FullCalanderTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Styles/css").Include(
                      "~/Styles/bootstrap.css",
                      "~/Styles/site.css"));

            //scripts
            bundles.Add(new ScriptBundle("~/bundles/calendarscripts").Include(
                                        "~/Scripts/jquery-{version}.js",
                                        "~/Scripts/Calendar/moment.min.js",
                                        "~/Scripts/Calendar/fullcalendar.min.js",
                                        "~/Scripts/Calendar/gcal.min.js",
                                        "~/Scripts/Calendar/jquery-ui.min.js"));
            //styles
            bundles.Add(new StyleBundle("~/bundles/calendarstyles").Include(
                                        "~/Styles/Calendar/fullcalendar.min.css",
                                        "~/Styles/Calendar/scheduler.min.css",
                                        "~/Styles/Calendar/CustomCalStyles.css"));
        }
    }
}
