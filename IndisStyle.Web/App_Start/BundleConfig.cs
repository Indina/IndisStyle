using System.Web.Optimization;

namespace IndisStyle.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Force optimization to be on or off, regardless of web.config setting
            //BundleTable.EnableOptimizations = false;
            bundles.UseCdn = false;
       
            // .debug.js, -vsdoc.js and .intellisense.js files 
            // are in BundleTable.Bundles.IgnoreList by default.
            // Clear out the list and add back the ones we want to ignore.
            // Don't add back .debug.js.
            bundles.IgnoreList.Clear();
            bundles.IgnoreList.Ignore("*-vsdoc.js");
            bundles.IgnoreList.Ignore("*intellisense.js");

            // Modernizr goes separate since it loads first
            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-{version}.js"));

            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery", 
                "//ajax.googleapis.com/ajax/libs/jquery/2.0.3/jquery.min.js")
                .Include("~/Scripts/jquery-{version}.js"));

            // 3rd Party JavaScript files
            bundles.Add(new ScriptBundle("~/bundles/jsextlibs")
                //.IncludeDirectory("~/Scripts/lib", "*.js", searchSubdirectories: false));
                .Include(
                    "~/Scripts/bootstrap.js"

                    ));
          

            // All application JS files (except mocks)
            bundles.Add(new ScriptBundle("~/bundles/jslibs")
                .IncludeDirectory("~/Scripts/libs/", "*.js", searchSubdirectories: true));

            // 3rd Party CSS files
            bundles.Add(new StyleBundle("~/Content/css")
                .IncludeDirectory("~/Content/libs/","*.css",searchSubdirectories:false)
                .Include(
                    "~/Content/bootstrap/bootstrap.css",
                    "~/Content/bootstrap/bootstrap-theme.css",
                    "~/Content/font-awesome.css",
                    "~/Content/font-awesome-ie7.css",
                    "~/Content/style.css"));

          
        }
    }
}