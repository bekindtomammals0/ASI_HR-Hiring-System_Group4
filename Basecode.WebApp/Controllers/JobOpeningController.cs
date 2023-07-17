using Basecode.Data.Models;
using Basecode.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer", Roles = "User")]
    public class JobOpeningController : Controller
    {
        private readonly IJobOpeningService _service;
        public JobOpeningController(IJobOpeningService service) 
        { 
            _service = service;
        }
        public IActionResult Index()
        {
            var data = _service.RetrieveAll();
            return View(data);
        }

        public IActionResult AddView() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(JobOpening model)
        {
            _service.Add(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateView(int id)
        {
            var data = _service.GetById(id);
            return View(data);
        }

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

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
