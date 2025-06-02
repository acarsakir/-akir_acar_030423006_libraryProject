using entityLayer.concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using şakir_acar_030423006_libraryProject.Models;

namespace şakir_acar_030423006_libraryProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<appUser> _signInManager;
        private readonly UserManager<appUser> _userManager;

        public AccountController(SignInManager<appUser> signInManager, UserManager<appUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false,true);
                if (result.Succeeded)
                {
                    var user=await _userManager.FindByNameAsync(model.UserName);
                    if (user.EmailConfirmed) {
                        return RedirectToAction("Index", "kitaplar"); // "Kitaplar" controller ismi büyük harfle
                    }
                    
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış.");
                }
            }
            return View();
            
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
