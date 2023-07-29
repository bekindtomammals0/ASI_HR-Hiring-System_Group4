using Basecode.Data.Models;
using Basecode.Main.Controllers;
using Basecode.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers
{
    public class ApplicationFormController : Controller
    {
        private readonly ILogger<ApplicationFormController> _logger;
        private readonly ILookupService _lookupService;
        // private readonly IEmploymentTypeService _ETservice;
        // private readonly IExperienceLevelService _ELservice;
        public ApplicationFormController(ILogger<ApplicationFormController> logger, ILookupService lookupService)
        {
            // _ETservice = employmentTypeService;
            // _ELservice = experienceLevelService;
            _lookupService = lookupService;
            _logger = logger;
        }
        public IActionResult Index()
        {
            // var employmentTypeData = _ETservice.RetrieveAll();
            var employmentTypeData = _lookupService.GetEmploymentTypes();
            var experienceLevelData = _lookupService.GetExperienceLevels();
            var civilStatusData = _lookupService.GetCivilStatuses();
            ViewBag.EmploymentTypes = employmentTypeData;
            ViewBag.ExperienceLevel = experienceLevelData;
            ViewBag.CivilStatus = civilStatusData;
            return View();
        }

        public IActionResult CharacterReference()
        {
            return View();
        }

        
    }
}
