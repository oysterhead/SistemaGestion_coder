using Microsoft.AspNetCore.Mvc;
using WebApiSistemaGestion.DTOs;
using WebApiSistemaGestion.Mapper;
using WebApiSistemaGestion.Models;
using WebApiSistemaGestion.Service;

namespace WebApiSistemaGestion.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductoVendidoController : Controller
    {
        private ProductoVendidoService productoVendidoService;
        readonly UsuarioService usuarioService;

        public ProductoVendidoController(
            ProductoVendidoService productoVendidoService,
            UsuarioService usuarioService)
        {
            this.productoVendidoService = productoVendidoService;
            this.usuarioService = usuarioService;
        }

        [HttpGet("{IdUsuario}")]
        public IActionResult ProductosVendidosPorUsuario(int IdUsuario)
        {
            Usuario usuario = this.usuarioService.ObtenerUsuarioPorId(IdUsuario);

            if (usuario == null)
            {
                return NotFound("Usuario no encontrado");
            }

            List<ProductoVendido> productosVendidos = this.productoVendidoService.BuscarProductosDelUsuario(usuario);

            List<ProductoVendidoDTO> productosVendidosDTO = new List<ProductoVendidoDTO>(productosVendidos.Count);

            foreach (ProductoVendido productoVendido in productosVendidos)
            {
                productosVendidosDTO.Add(ProductoVendidoMapper.MapearADTO(productoVendido));
            }

            return Ok(productosVendidosDTO);
        }
    }
}
