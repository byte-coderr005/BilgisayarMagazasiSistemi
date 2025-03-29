using Microsoft.AspNetCore.Mvc;

namespace BilgisayarMagazasiSistemi.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
