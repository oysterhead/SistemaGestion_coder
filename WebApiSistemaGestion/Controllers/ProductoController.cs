using Microsoft.AspNetCore.Mvc;

namespace WebApiSistemaGestion.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
