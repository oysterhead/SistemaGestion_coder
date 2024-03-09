using Microsoft.AspNetCore.Mvc;

namespace WebApiSistemaGestion.Controllers
{
    public class ProductoVendidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
