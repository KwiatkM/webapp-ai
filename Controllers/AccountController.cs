using Microsoft.AspNetCore.Mvc;
using webapp.Models;

namespace webapp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // W rzeczywistej aplikacji tutaj powinna być autentykacja użytkownika
                // Na razie symulujemy pomyślne logowanie
                _logger.LogInformation($"Próba logowania użytkownika: {model.Username}");
                
                // Symulacja logowania - w rzeczywistej aplikacji należy zintegrować z systemem autentykacji
                TempData["SuccessMessage"] = "Logowanie zakończone sukcesem!";
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            // W rzeczywistej aplikacji tutaj powinna być wylogowanie użytkownika
            _logger.LogInformation("Użytkownik się wylogował");
            TempData["SuccessMessage"] = "Zostałeś wylogowany";
            return RedirectToAction("Index", "Home");
        }
    }
}
