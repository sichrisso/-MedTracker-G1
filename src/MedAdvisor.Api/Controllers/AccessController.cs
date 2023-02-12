using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using AuthProject.Models;
using MedCrud.models;

namespace MedCrud.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;
            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");


            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login(VMLogin modelLogin)
        {
            if (modelLogin.Email == "user@example.com" &&
                modelLogin.Password == "123"
                )
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, modelLogin.Email),
                    new Claim("OtherProperties", "Example Role")

                };
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = modelLogin.KeepLoggedIn

                };

                await HttpContext.SignInAsync(cookieAuthenticationDefaults.AuthenticationScheme,
                    new claimsPrincipal(), properties);


                return RedirectToAction("Index", "Home");
            }


            ViewData["ValidateMessage"] = "user not found";
            return View();
        }
    }
}
