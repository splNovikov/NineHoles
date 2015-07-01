﻿using nineHoles.Utils;
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

				"~/Scripts/libs/jquery/jquery-{version}.js",
				"~/Scripts/libs/bootstrap/bootstrap.min.js"
				));

			bundles.Add(new StyleBundle("~/Content/css").Include(
				"~/Content/libs/bootstrap/bootstrap.css"
				));
		}

		private static void RegisterUserScriptBundle(BundleCollection bundles)
		{
			bundles.Add(new JsBundle("~/bundles/app").Include(

				/* Main */
				"~/Scripts/app/main/main.module.js",
				"~/Scripts/app/main/main.controller.js",

				"~/Scripts/app/app.js",
				"~/Scripts/app/app.layout.controller.js"));

			bundles.Add(new LessBundle("~/Content/siteLess").Include(
						"~/Content/appStyles/site.less"));
		}

	}
}