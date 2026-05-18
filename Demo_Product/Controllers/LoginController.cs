using Demo_Product.Models;
using EntityLayer.Conctrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        private readonly SignInManager<AppUser>? _signInManager;

        public LoginController(SignInManager<AppUser>? signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public  async Task<IActionResult> Index(UserLoginVİewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager!.PasswordSignInAsync(p.Username!,p.Password!,false,true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Category");
                }
                else
                {
                    ModelState.AddModelError("","Hatalı Kullanıcı adı veya şifre");
                }

            }
            
            return View();
        }

        [HttpPost] // Formu 'post' yaptığın için burası mutlaka HttpPost olmalı
        [ValidateAntiForgeryToken] // Güvenlik için formdan gelen gizli anahtarı kontrol eder
        public async Task<IActionResult> LogOut()
        {
            // 1. Kullanıcının oturumunu (Cookie) sistemden temizle
            await _signInManager!.SignOutAsync();

            // 2. Tarayıcı önbelleğini (Cache) temizle
            // Bu kodlar, geri tuşuna basıldığında sayfanın tekrar yüklenmesini zorunlu kılar
            Response.Headers.Append("Cache-Control", "no-cache, no-store, must-revalidate");
            Response.Headers.Append("Pragma", "no-cache");
            Response.Headers.Append("Expires", "0");

            // 3. Kullanıcıyı giriş sayfasına yönlendir
            return RedirectToAction("Index", "Login");
        }
    }
}
