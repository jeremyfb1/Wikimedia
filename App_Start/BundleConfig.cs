using System.Web;
using System.Web.Optimization;

namespace Wikimedia
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/validation").Include(
                        "~/Scripts/validation.js",
                        "~/Scripts/jquery-maskedinput.js",
                        "~/Scripts/bootbox.js",
                        "~/Scripts/selection.js",
                        "~/Scripts/SiteScripts.js",
                        "~/Scripts/session.js",
                        "~/Scripts/SiteNotificationsHandler.js",
                        "~/Scripts/autoRefreshPanel.js",
                        "~/Scripts/image-control.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/_layout.css",
                        "~/Content/Accounts.css",     // Ajouté du projet Auth
                        "~/Content/popup.css",        // Ajouté du projet Auth
                        "~/Content/Selection.css",    // Ajouté du projet Auth
                        "~/Content/site.css",
                        "~/Content/menu.css",
                        "~/Content/media.css",
                        "~/Content/Icons.css",        // Ajouté du projet Auth
                        "~/Content/image-control.css",
                        "~/Content/jqui-custom-datepicker.css"));
        }
    }
}