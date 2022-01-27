using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicSite.Models;
using MusicSite.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MusicSite.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
       
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            return View(model: new LoginModel
            {
                ReturnURL=returnUrl
            });
        }
        
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByNameAsync(loginModel.UserName);
                if (user != null)
                {
                    await _signInManager.SignOutAsync();
                    if ((await _signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).Succeeded)
                    {
                        return Redirect("/");
                    }
                }
            }
            ModelState.AddModelError("", "Nieprawidłowa nazwa użytkownika lub hasła");
            return View(loginModel);
        }
        [HttpGet]
        public IActionResult Register(String returnUrl)
        {
            return this.View(new RegisterModel
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (this.ModelState.IsValid)
            {
                User userData = new()
                {
                    Name = model.Name,
                    LastName = model.LastName,
                    CreationDate = model.CreationDate,
                    UserName = model.UserName,
                    Email = model.EMail,
                };
                IdentityResult newUser = await _userManager.CreateAsync(userData, model.Password);

                if (newUser.Succeeded)
                {
                    await _signInManager.SignInAsync(userData, true);
                    return this.Redirect(model?.ReturnUrl ?? "/");
                }

                foreach (IdentityError error in newUser.Errors)
                    this.ModelState.AddModelError(error.Code, error.Description);

                this.ModelState.AddModelError("Error", "Nie udało się zarejestrować");
            }

            return this.View(model);
        }

        public async Task<RedirectResult> Logout(string returnURL = "/")
        {
            await _signInManager.SignOutAsync();
            return Redirect(returnURL);
        }
    }
}
