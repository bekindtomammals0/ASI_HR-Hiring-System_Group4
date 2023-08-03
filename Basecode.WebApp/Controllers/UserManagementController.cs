using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers
{
    public class UserManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
