using Basecode.Data.Models;
using Basecode.Main.Controllers;
using Basecode.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers
{
    public class ApplicationFormController : Controller
    {
        private readonly ILogger<ApplicationFormController> _logger;
        // private readonly IEmploymentTypeService _ETservice;
        // private readonly IExperienceLevelService _ELservice;
        public ApplicationFormController(ILogger<ApplicationFormController> logger, IExperienceLevelService experienceLevelService, IEmploymentTypeService employmentTypeService)
        {
            // _ETservice = employmentTypeService;
            // _ELservice = experienceLevelService;
            _logger = logger;
        }
        public IActionResult Index()
        {
            // var employmentTypeData = _ETservice.RetrieveAll();
            return View();
        }

        public IActionResult CharacterReference()
        {
            return View();
        }

        
    }
}
