using IntecapBooks.Business.Entities;
using IntecapBooks.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntecapBooks.Controllers
{
    public class AccountController : Controller
    {
        UserManager<IdentityUser> _userManager;
        SignInManager<IdentityUser> _signInManager;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            var loginModel = new LoginViewModel();
            
            return View(loginModel);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel userFormData)
        {
            if (ModelState.IsValid) {

                var result = await _signInManager.PasswordSignInAsync(userFormData.Email, userFormData.Password, false, lockoutOnFailure: false);
                if (result.Succeeded) {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid credentials");
            }

            return View();
        }

        public IActionResult Register()
        {
            var registerModel = new RegisterViewModel();
            return View(registerModel);
        }
        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel userFormData)
        {

            if (ModelState.IsValid) {
                var user = new ApplicationUser
                {
                    Email = userFormData.Email,
                    StreetAddress = userFormData.StreetAddress,
                    City = userFormData.City,
                    Name = userFormData.Name,
                    UserName = userFormData.Email,
                    NormalizedUserName = userFormData.Email,
                    Password = userFormData.Password

                };
                var result = await _userManager.CreateAsync(user, user.Password);
                if (result.Succeeded) {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(userFormData);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
