using Microsoft.AspNetCore.Mvc;

namespace AdminLayer.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult GirisYap()
		{
			return View();
		}

	}
}
