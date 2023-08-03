using Basecode.Data.ViewModels;
using Basecode.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAdminService _service;

        public AdminController(RoleManager<IdentityRole> roleManager, IAdminService service) {
            _roleManager = roleManager;
            _service = service;
        }    
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RoleManagement()
        {
            return View();
        }

        public IActionResult CreateRole()
        {
             return View("RoleManagement/CreateRole");
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel createRoleViewModel)
        {
            if(ModelState.IsValid)
            {

                IdentityResult result = await _service.CreateRole(createRoleViewModel.RoleName);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Admin");
                }
            }
            
            return View();
        }
    }
}
