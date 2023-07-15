using Basecode.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Basecode.Services.Interfaces;
using Basecode.Services.Services;
using Basecode.Data.ViewModels;


namespace Basecode.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}