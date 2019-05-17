using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MusicApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace MusicApi.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;

        public AccountController(UserManager<User> usrMgr, SignInManager<User> signinMgr)
        {
            userManager = usrMgr;
            signInManager = signinMgr;
        }
        //public ViewResult Index() => View(userManager.Users);

        public ViewResult Register() => View();

        public ViewResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = model.Name,
                    UserEmail = model.Email
                };
                IdentityResult result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach(IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(LoginModel details, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                User user = await userManager.FindByNameAsync(details.Name);
                if (user != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result =
                        await signInManager.PasswordSignInAsync(
                            user, details.Password, false, false);
                    if (result.Succeeded)
                    {
                        Response.Cookies.Append("UserID", user.UserId.ToString());
                        Response.Cookies.Append("UserName", user.UserName);
                        //Response.Cookies.Append(user.UserId.ToString(), user.UserName);

                        //return RedirectToAction("userPage");

                        return RedirectToAction("Index");
                    }
                }
                ModelState.AddModelError(nameof(LoginModel.Name),
                    "Invalid user or password");
            }

            return View(details);
        }
        public ViewResult UserPage() => View();
    }
}
