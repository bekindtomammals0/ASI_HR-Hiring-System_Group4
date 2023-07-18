using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
