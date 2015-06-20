using System.Web.Mvc;

namespace nineHoles.Controllers
{
	public class MainController : Controller
	{
		public ActionResult Index()
		{
			return PartialView("~/Views/Main/_Index.cshtml");
		}

	}
}
