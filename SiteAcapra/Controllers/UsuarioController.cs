using Microsoft.AspNetCore.Mvc;

namespace SiteAcapra.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
