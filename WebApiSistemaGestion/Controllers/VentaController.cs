using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.DTOs;
using WebApiSistemaGestion.Mapper;
using WebApiSistemaGestion.Models;
using WebApiSistemaGestion.Service;

namespace WebApiSistemaGestion.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class VentaController : Controller
    {

        private VentaService ventaService;
        readonly UsuarioService usuarioService;
        public VentaController(VentaService ventaService, UsuarioService usuarioService)
        {
            this.ventaService = ventaService;
            this.usuarioService = usuarioService;
        }

        [HttpPost("{IdUsuario}")]
        public IActionResult CrearVentaDelUsuario(int IdUsuario, [FromBody] List<ProductoDTO> productoDTO)
        {
            if (IdUsuario > 0)
            {
                Usuario usuario = this.usuarioService.ObtenerUsuarioPorId(IdUsuario);

                if (usuario == null)
                {
                    return NotFound("Usuario no encontrado");
                }

                if (productoDTO.Count == 0)
                {
                    return base.BadRequest(new { mensaje = "No se recibieron productos necesarios para la venta", status = HttpStatusCode.BadRequest });
                }
                try
                {
                    this.ventaService.NuevaVenta(IdUsuario, productoDTO);
                    IActionResult result = base.Created(nameof(CrearVentaDelUsuario), new
                    {
                        mensaje = "Venta realizada con éxito",
                        status = HttpStatusCode.Created,
                        nuevaVenta = productoDTO
                    });
                    return result;
                }
                catch (Exception ex) { return base.Conflict(new { mensaje = ex.Message, status = HttpStatusCode.Conflict }); }
            }
            else { return base.Conflict(new { mensaje = "El Id de usuario no puede ser negativo", status = HttpStatusCode.Conflict }); }
        }
         

        [HttpGet("{IdUsuario}")]
        public IActionResult MostrarVentaDelUsuario(int IdUsuario)
        {
            if (IdUsuario > 0)
            {
                Usuario usuario = this.usuarioService.ObtenerUsuarioPorId(IdUsuario);

                if (usuario == null)
                {
                    return NotFound("Usuario no encontrado");
                }

                List<Venta> ventasDelUsuario = this.ventaService.ObtenerVentasDelUsuario(IdUsuario);
                if(ventasDelUsuario.Count == 0)
                {
                    return base.Conflict(new { mensaje = $"El Usuario con Id {IdUsuario} no tiene ventas." });
                }

                List<VentaDTO> ventasDTO = new List<VentaDTO>();
                foreach (Venta venta in ventasDelUsuario)
                {
                    VentaDTO ventaDTO = VentaMapper.MapearADTO(venta);
                    ventasDTO.Add(ventaDTO);
                }
                return base.Ok(ventasDTO);

            }
            else
            {
                return base.Conflict(new { mensaje = "El id debe ser positivo", status = 409 });
            }
        }

    }
}
