using Basecode.Data.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Basecode.WebApp.Controllers
{
    public class AccountManagerController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        //constructor
        public AccountManagerController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegistrationViewModel registrationViewModel)
        {
            if(ModelState.IsValid)
            {
                var userToRegister = new IdentityUser { UserName = registrationViewModel.UserName, Email = registrationViewModel.Email };
                var result = await userManager.CreateAsync(userToRegister, registrationViewModel.Password);

                if(result.Succeeded)
                {
                    await signInManager.SignInAsync(userToRegister, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return RedirectToAction("RegisterView");
        }
        [HttpPost]
        public async Task<IActionResult> logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, loginViewModel.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return RedirectToAction("LoginView");
        }
        [HttpGet]
        public IActionResult RegisterView()
        {
            return View("~/Areas/Identity/Pages/Account/Register.cshtml");
        }
        [HttpGet]
        public IActionResult LoginView()
        {
            return View("~/Areas/Identity/Pages/Account/Login.cshtml");
        }
    }
}
