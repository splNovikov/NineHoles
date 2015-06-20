using nineHoles.Utils;
using System.Web.Optimization;

namespace nineHoles
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			BundleTable.EnableOptimizations = true;

			RegisterThirdPartyLibs(bundles);

			RegisterUserScriptBundle(bundles);
		}

		private static void RegisterThirdPartyLibs(BundleCollection bundles)
		{
			bundles.Add(new JsBundle("~/bundles/libs").Include(
				"~/Scripts/libs/angular/angular.js",
				"~/Scripts/libs/angular-router/angular-ui-router.js"
				));

			bundles.Add(new StyleBundle("~/Content/css").Include(
				"~/Content/libs/bootstrap/bootstrap.css"
				));
		}

		private static void RegisterUserScriptBundle(BundleCollection bundles)
		{
			bundles.Add(new JsBundle("~/bundles/app").Include(
				"~/Scripts/app/app.js",
				"~/Scripts/app/app.layout.controller.js"));

			bundles.Add(new LessBundle("~/Content/siteLess").Include(
						"~/Content/appStyles/site.less"));
		}

	}
}