using Microsoft.AspNetCore.Mvc;

namespace SiteAcapra.Controllers
{
    public class EspecieController : Controller
    {
        public IActionResult CadastroEspecie()
        {
            return View();
        }
    }
}
