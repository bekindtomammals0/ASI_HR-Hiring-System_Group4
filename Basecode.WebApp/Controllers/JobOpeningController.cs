using Basecode.Data.Models;
using Basecode.Data.ViewModels;
using Basecode.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers
{
    
    public class JobOpeningController : Controller
    {
        private readonly IJobOpeningService _service;
        private readonly ILookupService _lookupService;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public JobOpeningController(IJobOpeningService service, ILookupService lookupService) 
        { 
            _service = service;
            _lookupService = lookupService;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.ExperienceLevels = _lookupService.GetExperienceLevels();
            ViewBag.EmploymentTypes = _lookupService.GetEmploymentTypes();
            var data = _service.RetrieveAll();
            return View(data);
        }
        public IActionResult AddView() 
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Add(JobOpening model)
        {
            model.CreatedBy = User.Identity.Name;
            model.UpdatedBy = User.Identity.Name;
            _service.Add(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateView(int id)
        {
            var data = _service.GetById(id);
            return View(data);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Update(JobOpening model)
        {
            _service.Update(model);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteView(int id)
        {
            var data = _service.GetById(id);
            return View(data);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult PartialUpdate(int id)
        {
            JobOpeningViewModel jobOpeningViewModel = _service.GetById(id);
            JobOpening jobOpening = new JobOpening { Title = jobOpeningViewModel.Title, Description = jobOpeningViewModel.Description
                                                , ExperienceLevelID = jobOpeningViewModel.ExperienceLevelID, 
                                                    EmploymentTypeID = jobOpeningViewModel.EmploymentTypeID};
            return PartialView("UpdateView", jobOpening);
        }
    }
}
