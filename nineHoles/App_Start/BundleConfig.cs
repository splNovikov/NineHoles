using nineHoles.Utils;
using System.Web.Optimization;

namespace nineHoles
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			BundleTable.EnableOptimizations = false;

			RegisterThirdPartyLibs(bundles);

			RegisterUserScriptBundle(bundles);
		}

		private static void RegisterThirdPartyLibs(BundleCollection bundles)
		{
			bundles.Add(new JsBundle("~/bundles/libs").Include(
				"~/Scripts/libs/angular/angular.js",
				"~/Scripts/libs/angular-router/angular-ui-router.js",
				"~/Scripts/libs/angular/angular-touch.js",
				"~/Scripts/libs/angular-mobile/angular-mobile.js",
				"~/Scripts/libs/angular-carusel/angular-carousel.js",

				"~/Scripts/libs/jquery/jquery-{version}.js",
				"~/Scripts/libs/bootstrap/bootstrap.min.js",

				"~/Scripts/libs/lodash/lodash.min.js",
				"~/Scripts/libs/angular-google-maps/angular-google-maps.min.js"
				));

			bundles.Add(new StyleBundle("~/Content/css").Include(
				"~/Content/libs/bootstrap/bootstrap.css",
				"~/Content/libs/angular-carusel/angular-carousel.css"
				));
		}

		private static void RegisterUserScriptBundle(BundleCollection bundles)
		{
			bundles.Add(new JsBundle("~/bundles/app").Include(

				/* Main */
				"~/Scripts/app/main/main.module.js",
				"~/Scripts/app/main/main.controller.js",

				/* Places */
				"~/Scripts/app/places/places.module.js",
				"~/Scripts/app/places/places.controller.js",

				/* Gallery */
				"~/Scripts/app/gallery/gallery.module.js",
				"~/Scripts/app/gallery/gallery.controller.js",

				"~/Scripts/app/app.js",
				"~/Scripts/app/app.layout.controller.js"));

			bundles.Add(new LessBundle("~/Content/siteLess").Include(
						"~/Content/appStyles/site.less"));
		}

	}
}