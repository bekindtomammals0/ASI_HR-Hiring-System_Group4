
using Basecode.Data.Models;
using Basecode.Main.Controllers;
using Basecode.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Basecode.Data.ViewModels;

namespace Basecode.WebApp.Controllers
{
    public class ApplicationFormController : Controller
    {
        private readonly IApplicantService _applicantService;
        private readonly ILogger<ApplicationFormController> _logger;
        private readonly ILookupService _lookupService;
        // private readonly IEmploymentTypeService _ETservice;
        // private readonly IExperienceLevelService _ELservice;
        public ApplicationFormController(ILogger<ApplicationFormController> logger, ILookupService lookupService, IApplicantService applicantService)
        {
            // _ETservice = employmentTypeService;
            // _ELservice = experienceLevelService;
            _applicantService = applicantService;
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
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddApplicant(ApplicationFormViewModel model)
        {
            Applicant applicant = new Applicant
            {
                Id = model.ApplicantId,
                JobOpeningID = model.JobOpeningId,
                ApplicantFirstName = model.ApplicantFirstName,
                ApplicantLastName = model.ApplicantLastName,
                ApplicantEmail = model.ApplicantEmail,
                ApplicantContactNumber = model.ApplicantContactNumber,
                CivilStatusID = model.CivilStatusID,
                CVId = model.CVId,
                CharacterReferenceID = model.CharacterReferenceID,
            };
            _applicantService.Add(applicant);
            return RedirectToAction("Index", "JobOpening");
        }

        public IActionResult CharacterReference()
        {
            return View();
        }


    }
}
