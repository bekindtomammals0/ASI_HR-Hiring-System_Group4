using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers
{
    public class UserViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
