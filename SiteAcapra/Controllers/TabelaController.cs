using Microsoft.AspNetCore.Mvc;

namespace SiteAcapra.Controllers
{
    public class TabelaController : Controller
    {
        public IActionResult TabelaRaca()
        {
            return View();
        }

        public IActionResult TabelaEspecie()
        {
            return View();
        }

        public IActionResult TabelaVacina()
        {
            return View();
        }
    }
}