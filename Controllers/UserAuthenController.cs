﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectWithLogin.Models.DTO;
using ProjectWithLogin.Repository.Implementation;

namespace ProjectWithLogin.Controllers
{
    public class UserAuthenController : Controller
    {
        private readonly IUserAuthenServices _services;
        public UserAuthenController(IUserAuthenServices services)
        {
            this._services = services;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var result = await _services.LoginAsync(model);
            if (result.StatusCode == 1)
            {
                return RedirectToAction("Display", "Dashboard");
            }
            else
            {
                TempData["msg"] = result.Message;
                return RedirectToAction(nameof(Login));
            }
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegistrationAsync(RegistrationModel model)
        {
            if (!ModelState.IsValid) { return View(model); }
            model.Role = "user";
            var result = await this._services.RegistrationAsync(model);
            TempData["msg"] = result.Message;
            return RedirectToAction(nameof(Registration));
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _services.LogoutAsync();
            return RedirectToAction(nameof(Login));
        }

        //[Authorize]
        //public IActionResult ChangePassword()
        //{
        //    return View();
        //}

        //[Authorize]
        //[HttpPost]
        //public async Task<IActionResult> ChangePassword(ChangePasswordModel model)
        //{
        //    if (!ModelState.IsValid)
        //        return View(model);
        //    var result = await _services.ChangePasswordAsync(model, User.Identity.Name);
        //    TempData["msg"] = result.Message;
        //    return RedirectToAction(nameof(ChangePassword));
        //}

    }
}
