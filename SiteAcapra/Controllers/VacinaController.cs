using Microsoft.AspNetCore.Mvc;

namespace SiteAcapra.Controllers
{
    public class VacinaController : Controller
    {
        public IActionResult CadastroVacina()
        {
            return View();
        }
    }
}