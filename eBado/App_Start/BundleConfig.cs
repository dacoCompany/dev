using System.Web;
using System.Web.Optimization;

namespace eBado
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Assets/js/jquery-1.11.1.min.js",
                        "~/Assets/js/bootstrap.js",
                        "~/Assets/js/bootstrap-hover-dropdown.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Assets/css/bootstrap.css",
                      "~/Assets/css/style.css",
                      "~/Assets/css/button.css",
                      "~/Assets/css/reset.css",
                      "~/Assets/css/font-awesome.min.css",
                      "~/Assets/css/media-queries.css"));
        }
    }
}
