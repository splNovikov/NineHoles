using System.Web.Mvc;

namespace nineHoles.Controllers
{
	public class MainController : Controller
	{
		public ActionResult Index()
		{
			return PartialView("~/Views/Main/_Index.cshtml");
		}

		public ActionResult Minigolf()
		{
			return PartialView("~/Views/Main/_Minigolf.cshtml");
		}

		public ActionResult Places()
		{
			return PartialView("~/Views/Main/_Places.cshtml");
		}

		public ActionResult Services()
		{
			return PartialView("~/Views/Main/_Services.cshtml");
		}

		public ActionResult Gallery()
		{
			return PartialView("~/Views/Main/_Gallery.cshtml");
		}

		public ActionResult Discounts()
		{
			return PartialView("~/Views/Main/_Discounts.cshtml");
		}

	}
}
