using Microsoft.AspNetCore.Mvc;

namespace VuelosCRUD.Controllers
{
	public class VuelosController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
