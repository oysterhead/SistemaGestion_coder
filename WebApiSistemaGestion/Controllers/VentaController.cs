using Microsoft.AspNetCore.Mvc;
using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.Service;

namespace WebApiSistemaGestion.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class VentaController : Controller
    {

        private VentaService ventaService;
        public VentaController(VentaService ventaService)
        {
            this.ventaService = ventaService;
        }

        [HttpPut("{IdUsuario}")]
        public IActionResult CrearVentaDelUsuario(int IdUsuario)
        {
        
        }
    }
}
