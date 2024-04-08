using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using turboaz.Models;

namespace turboaz.Controllers
{
    public class UserController : Controller
    {
        private readonly turboazContext _sql;
        public UserController(turboazContext sql)
        {
            _sql = sql;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User u)
        {
            var user = _sql.Users.SingleOrDefault(x=>x.UserName == u.UserName && x.UserPassword==u.UserPassword);
            if (user != null)
            {
                List<Claim> claim = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Surname, user.UserSurname),
                    new Claim(ClaimTypes.Sid, user.UserId.ToString()),
                    new Claim("Status",user.UserActive)
                };
                var identity = new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme);
                var prins = new ClaimsPrincipal(identity);
                var props = new AuthenticationProperties();
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, prins, props ).Wait();
            return RedirectToAction("Index","Home");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Cixis()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme).Wait();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Registr()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registr(User u)
        {
            u.UserDescription = "User";
            u.UserActive = "Active";
            _sql.Users.Add(u);
            _sql.SaveChanges();
            return RedirectToAction("Index","Home");
        }

        public IActionResult Block(int id)
        {
            var a = _sql.Users.SingleOrDefault(x => x.UserId == id);
            if (a.UserActive=="block")
            {
                a.UserActive = "active";
            }
            else
            {
                a.UserActive = "block"; 
                    }
            _sql.SaveChanges();
            return RedirectToAction("Istifadeci","Home");
        }


    }
}
