using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers
{
    public class SchedulerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
