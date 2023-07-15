using Basecode.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Basecode.Services.Interfaces;
using Basecode.Services.Services;
using Basecode.Data.ViewModels;


namespace Basecode.WebApp.Controllers
{
    public class JobOpeningController : Controller
    {
        private readonly ILogger<JobOpeningController> _logger;

        public JobOpeningController(ILogger<JobOpeningController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}