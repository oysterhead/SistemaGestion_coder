using Microsoft.AspNetCore.Mvc;
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
        public IActionResult CrearVentaDelUsuario(int IdUsuario, [FromBody] VentaDTO ventaDTO)
        {
            if (IdUsuario > 0) 
            {
                Usuario usuario = this.usuarioService.ObtenerUsuarioPorId(IdUsuario);

                if (usuario == null)
                {
                    return NotFound("Usuario no encontrado");
                }

                if (this.ventaService.NuevaVenta(ventaDTO))
                {
                    return base.Ok(new { mensaje = "Venta resgistrada exitosamente", status = 200, ventaDTO });
                }
                    
                else { return base.Conflict(new { mensaje = "Ha ocurrido un problema al agregar una venta", status = 200 }); }
            }
            else
            {
                return base.Conflict(new { mensaje = "El id debe ser positivo", status = 409 });
            }

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
