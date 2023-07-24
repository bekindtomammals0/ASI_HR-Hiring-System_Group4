using Basecode.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Basecode.Data.Constants;

namespace Basecode.WebApp.Controllers
{
    public class AccountManagerController : Controller
    {
        //properties
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        //constructor
        public AccountManagerController(UserManager<IdentityUser> userManager, 
                                        SignInManager<IdentityUser> signInManager,
                                        RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        //CRUD methods
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel createRoleViewModel) //create role
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = createRoleViewModel.RoleName
                };

                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                foreach(IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(createRoleViewModel);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Register(RegistrationViewModel registrationViewModel)  //register new user
        {
            if (ModelState.IsValid)
            {
                var userToRegister = new IdentityUser { UserName = registrationViewModel.UserName, Email = registrationViewModel.Email };
                var result = await userManager.CreateAsync(userToRegister, registrationViewModel.Password);

                if (!await roleManager.RoleExistsAsync("User"))
                {
                    IdentityRole identityRole = new IdentityRole
                    {
                        Name = "User"
                    };
                    await roleManager.CreateAsync(identityRole);
                }
                if (!await roleManager.RoleExistsAsync("Admin"))
                {
                    IdentityRole identityRole = new IdentityRole
                    {
                        Name = "Admin"
                    };
                    await roleManager.CreateAsync(identityRole);
                }

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(userToRegister, "User");
                    await signInManager.SignInAsync(userToRegister, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(registrationViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditUserRole(EditUserRoleViewModel editUserRoleViewModel)
        {
            if (ModelState.IsValid)
            {
                string userToFind = editUserRoleViewModel.User;
                string role = editUserRoleViewModel.Role;
                IdentityUser user = await userManager.FindByNameAsync(userToFind);
                List<string> rolesToRemove = new List<string>();

                foreach (var roleToRemove in roleManager.Roles)
                {
                    rolesToRemove.Add(roleToRemove.Name);
                }
                for(int i= 0; i<rolesToRemove.Count; i++)
                {
                    await userManager.RemoveFromRoleAsync(user, rolesToRemove[i]);
                }

                if (user != null)
                {
                    var result = await userManager.AddToRoleAsync(user, role);
                }
            }
            var userList = new List<string>();
            var roleList = new List<string>();

            foreach (var user in userManager.Users)
            {
                var name = user.UserName;
                userList.Add(name);
            }
            foreach (var role in roleManager.Roles)
            {
                var name = role.Name;
                roleList.Add(name);
            }
            ViewBag.UserList = userList;
            ViewBag.RoleList = roleList;
            return View(editUserRoleViewModel);
        }
        //Page redirect methods
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
            return View(loginViewModel);
        }
        [HttpGet]
        public IActionResult RegisterView()
        {
            return View("Register");
        }
        [HttpGet]
        public IActionResult EditUserRole()
        {
            EditUserRoleViewModel model = new EditUserRoleViewModel();
            var userList = new List<string>();
            var roleList = new List<string>();

            foreach (var user in userManager.Users)
            {
                var name = user.UserName;
                userList.Add(name);
            }
            foreach (var role in roleManager.Roles)
            {
                var name = role.Name;
                roleList.Add(name);
            }
            ViewBag.UserList = userList;
            ViewBag.RoleList = roleList;
            model.UserList = userList;
            model.RoleList = roleList;
            return View(model);
        }
        [HttpGet]
        public IActionResult LoginView()
        {
            return View("Login");
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
    }
}
