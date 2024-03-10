using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using WebApiSistemaGestion.DTOs;
using WebApiSistemaGestion.Mapper;
using WebApiSistemaGestion.Models;
using WebApiSistemaGestion.Service;

namespace WebApiSistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        private ProductoService productoService;
        public ProductoController(ProductoService productoService)
        {
            this.productoService = productoService;
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
        [HttpPut("{id}")]
        public IActionResult ModificarProductoPorId(int id, [FromBody] ProductoDTO productoDTO)
        {
            if (id > 0)
            {
                try
                {
                    this.productoService.ModificarProductoPorId(productoDTO, id);
                    return base.Ok(new { mensaje = $"Producto con Id {id} actualizado con éxito", status = 200, productoDTO });

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

        [HttpGet("Productos")]
        public IActionResult ListarProductos()
        {
            List<Producto> productos = productoService.ListarProductos();
            if (productos.Count > 0)
            {
                return Ok(new { mensaje = "Productos Existentes", status = 200, productos});
            }
            else { return base.Conflict(new { mensaje = "Ha ocurrido un problema.", status = 400 }); }
        }

        [HttpGet("Producto/{id}")]
        public IActionResult ListarProductoPorId(int id)
        {
            if (id > 0)
            {
                try
                {
                    Producto productoBuscado = this.productoService.BuscarProductoPorId(id);
                    ProductoDTO productoBuscadoDTO = ProductoMapper.MapearADTO(productoBuscado);
                    return base.Ok(productoBuscadoDTO);

                }
                catch (Exception ex)
                {
                    return BadRequest(new { mensaje = $"Ha ocurrido un error {ex.Message}", status = 400 });
                }
            }
            else
            {
                return base.Conflict(new { mensaje = "El id debe ser positivo", status = 409 });
            }
        }
    }
}
