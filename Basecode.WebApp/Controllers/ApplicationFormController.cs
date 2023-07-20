using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers
{
    public class ApplicationFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CharacterReference()
        {
            return View();
        }
    }
}
