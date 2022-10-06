using System.Web;
using System.Web.Optimization;

namespace LaPoderosaWebMVC
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //Agrgamos un nuevo bundle para el estilo Uza
            bundles.Add(new StyleBundle("~/Content/Styleuza").Include(
                       "~/Content/uza/fonts/aileron-font-style.css",
                       "~/Content/uza/css/bootstrap.min.css",
                       "~/Content/uza/css/animate.css",
                       "~/Content/uza/css/default-assets/classy-nav.css",
                       "~/Content/uza/css/owl.carousel.min.css",
                       "~/Content/uza/css/magnific-popup.css",
                       "~/Content/uza/css/font-awesome.min.css",
                       "~/Content/uza/css/style.css",
                     "~/Content/uza/style.css",
                     "~/Content/uza/style.css.map"));
            bundles.Add(new ScriptBundle("~/bundles/uzajquery").Include(
                      "~/Content/uza/js/jquery.min.js"
                      , "~/Content/uza/js/popper.min.js"
                       , "~/Content/uza/js/bootstrap.min.js"
                       , "~/Content/uza/js/uza.bundle.js"
                       , "~/Content/uza/js/default-assets/active.js"));

            //Agregamos un nuevo bundle para el dashboard
            bundles.Add(new StyleBundle("~/Content/dashboard/css").Include(
                    "~/Content/dashboard/assets/plugins/bootstrap/css/bootstrap.min.css"
                    , "~/Content/dashboard/html/css/style.css"
                    , "~/Content/dashboard/html/css/colors/default-dark.css"));
            bundles.Add(new ScriptBundle("~/bundles/dashboard/jquery").Include(
                    "~/Content/dashboard/assets/plugins/jquery/jquery.min.js"
                    , "~/Content/dashboard/assets/plugins/bootstrap/js/popper.min.js"
                    , "~/Content/dashboard/assets/plugins/bootstrap/js/bootstrap.min.js"
                    , "~/Content/dashboard/html/js/perfect-scrollbar.jquery.min.js"
                     , "~/Content/dashboard/html/js/waves.js"
                      , "~/Content/dashboard/html/js/sidebarmenu.js"
                      , "~/Content/dashboard/html/js/custom.min.js"
                    ));
        }
    }
}
