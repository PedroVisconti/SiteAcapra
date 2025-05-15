using Microsoft.AspNetCore.Mvc;

namespace SiteAcapra.Controllers
{
    public class CatalogoController : Controller
    {
        public IActionResult Catalogo()
        {
            return View();
        }
       
    }
}

