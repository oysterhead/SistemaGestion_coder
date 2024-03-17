using Microsoft.AspNetCore.Mvc;
using WebApiSistemaGestion.Service;

namespace WebApiSistemaGestion.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductoVendidoController : Controller
    {
        private ProductoVendidoService productoVendidoService;
        public ProductoVendidoController(ProductoVendidoService productoVendidoService)
        {
            this.productoVendidoService = productoVendidoService;
        }

        [HttpGet("{IdUsuario}")]
        public IActionResult ProductosVendidosPorUsuario(int IdUsuario)
        {
            if (IdUsuario > 0)
            {
                ProductoVendidoService productoVendidoService = this.productoVendidoService.BuscarProductosDelUsuario(IdUsuario);
            }
            else { return base.Conflict(new { mensaje = "El id debe ser positivo", status = 409 }); }
        }
    }
}
