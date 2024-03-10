using Microsoft.AspNetCore.Mvc;
using WebApiSistemaGestion.DTOs;
using WebApiSistemaGestion.Models;
using WebApiSistemaGestion.Service;

namespace WebApiSistemaGestion.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class ProductoController : Controller
    {
        private ProductoService productoService;
        public ProductoController(ProductoService productoService)
        {
            this.productoService = productoService;
        }

        [HttpGet]
        public ActionResult<string> Index(string nombre, string edad)
        {
            return base.Ok(new {mensaje = "Hola", estado = 200, parametros = new List<string> { nombre, edad} });
        }

        [HttpPost]
        public IActionResult AgregarNuevoProducto([FromBody] ProductoDTO nuevoProductoDTO)
        {
            if (this.productoService.NuevoProducto(nuevoProductoDTO))
            {
                return base.Ok(nuevoProductoDTO);
            }
            else { return Ok(nuevoProductoDTO); }
        }

        [HttpDelete("{id}")]
        public IActionResult BorrarProducto(int id)
        {
            if (id > 0)
            {
                try
                {
                    this.productoService.EliminarProducto(id);
                    return base.Ok(new { mensaje = $"Producto con Id {id} eliminado con éxito", status = 200 });

                }
                catch (Exception ex)
                {
                    return BadRequest(new { mensaje = $"Ha ocurrido el siguiente error {ex.Message}", status = 400 });
                }
            }
            else
            {
                return base.Conflict(new { mensaje = "El id debe ser positivo", status = 409 });
            }
        }
    }
}
