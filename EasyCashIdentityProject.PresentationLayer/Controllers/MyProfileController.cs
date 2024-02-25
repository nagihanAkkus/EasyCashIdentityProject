using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
	public class MyProfileController : Controller
	{
		public IActionResult Index()
		{
			// sessiona bak dolumu. dolu ise sayfayı göster. dolu değilse giriş yap a yönlendir

			return View();
		}
	}
}
