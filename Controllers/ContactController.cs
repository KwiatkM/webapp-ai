using Microsoft.AspNetCore.Mvc;
using webapp.Models;

namespace webapp.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Dziękujemy za kontakt!";
                return View();
            }
            return View(model);
        }
    }
}
