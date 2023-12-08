using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Pri.Cocktails.Vue.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {            
            return View();
        }
        public IActionResult LoggedIn([FromQuery] string role)
        {
            var cookie = new CookieOptions
            {
                HttpOnly = true,
                SameSite = SameSiteMode.Strict,
                Expires = DateTimeOffset.Now.AddDays(7),

            };
            Response.Cookies.Append("role", role);
            return RedirectToAction("CocktailsOfUserIndex", "Cocktails");
        }

        public IActionResult Register()
        {
            return View();
        }

    }
}
