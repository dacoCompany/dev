using System.Web;
using System.Web.Optimization;

namespace Web.eBado
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Assets/js/jquery-3.1.1.js",
                        "~/Assets/js/bootstrap.js",
                        "~/Assets/js/style.js",
                        "~/Assets/js/bootstrap-hover-dropdown.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Assets/css/bootstrap.css",
                      "~/Assets/css/bootstrap-theme.css",
                      "~/Assets/css/style.css",
                      "~/Assets/css/button.css",
                      "~/Assets/css/reset.css",
                      "~/Assets/css/font-awesome.min.css",
                      "~/Assets/css/media-queries.css"));
        }
    }
}
