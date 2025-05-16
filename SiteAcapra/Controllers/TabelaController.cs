using Microsoft.AspNetCore.Mvc;

namespace SiteAcapra.Controllers
{
    public class TabelaController : Controller
    {
        public IActionResult TabelaRaca()
        {
            return View();
        }
    }
}