using Basecode.Data.ViewModels;
using Basecode.Services.Interfaces;
using Basecode.Services.Services;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace Basecode.WebApp.Controllers
{
   
    public class StudentController : Controller
    {
        private readonly IStudentService _service;
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                ErrorHandling.Log data = _service.Register(studentModel);
                if (!data.Result)
                {
                    _logger.Error(ErrorHandling.SetLog(data));
                    return RedirectToAction("Index", "Student");
                }
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
