using Microsoft.AspNetCore.Mvc;

namespace SiteAcapra.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult CadastroAnimal()
        {
            return View();
        }
    }
}

