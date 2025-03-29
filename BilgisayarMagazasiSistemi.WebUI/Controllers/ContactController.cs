using Microsoft.AspNetCore.Mvc;

namespace BilgisayarMagazasiSistemi.WebUI.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, string email, string message)
        {
           
            ViewBag.Message = "Mesajınız başarıyla gönderildi.";
            return View();
        }
    }
}
