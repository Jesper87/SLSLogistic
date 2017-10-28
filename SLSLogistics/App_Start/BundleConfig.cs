using System.Web.Optimization;

namespace SLSLogistics
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.min.js"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.min.js",
					  "~/Scripts/respond.js",
				"~/Scripts/contact_me.js",
				"~/Scripts/jqBootstrapValidation.js",
				"~/Scripts/popper.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.min.css",
					  "~/Content/modern-business.css",
					  "~/Content/font-awesome.min.css",
					  "~/Content/Site.css"));
		}
	}
}
