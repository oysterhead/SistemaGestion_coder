using Microsoft.AspNetCore.Mvc;

namespace WebApiSistemaGestion.Controllers
{
    public class VentaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
