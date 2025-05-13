using Microsoft.AspNetCore.Mvc;

namespace SiteAcapra.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Formulario()
        {
            return View();
        }
    }
}