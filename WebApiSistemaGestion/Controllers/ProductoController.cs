using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.DTOs;
using WebApiSistemaGestion.Mapper;
using WebApiSistemaGestion.Models;
using WebApiSistemaGestion.Service;

namespace WebApiSistemaGestion.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductoController : Controller
    {
        private ProductoService productoService;
        readonly UsuarioService usuarioService;

        public ProductoController(ProductoService productoService, UsuarioService usuarioService)
        {
            this.productoService = productoService;
            this.usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult AgregarNuevoProducto([FromBody] ProductoDTO nuevoProductoDTO)
        {
            if (this.productoService.NuevoProducto(nuevoProductoDTO))
            {
                return base.Ok(nuevoProductoDTO);
            }
            else { return base.Conflict(new { mensaje = "Ha ocurrido un problema al agregar un usuario", status = 200 }); }
        }

        [HttpDelete("{IdProducto}")]
        public IActionResult BorrarProducto(int IdProducto)
        {
            if (IdProducto > 0)
            {
                try
                {
                    this.productoService.EliminarProducto(IdProducto);
                    return base.Ok(new { mensaje = $"Producto con Id {IdProducto} eliminado con éxito", status = 200 });

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

        //[HttpGet("Productos")]
        //public IActionResult ListarProductos()
        //{
        //    List<Producto> productos = productoService.ListarProductos();
        //    if (productos.Count > 0)
        //    {
        //        return Ok(new { mensaje = "Productos Existentes", status = 200, productos });
        //    }
        //    else { return base.Conflict(new { mensaje = "Ha ocurrido un problema.", status = 400 }); }
        //}

        //[HttpGet("Producto/{id}")]
        //public IActionResult ListarProductoPorId(int id)
        //{
        //    if (id > 0)
        //    {
        //        try
        //        {
        //            Producto productoBuscado = this.productoService.BuscarProductoPorId(id);
        //            ProductoDTO productoBuscadoDTO = ProductoMapper.MapearADTO(productoBuscado);
        //            return base.Ok(productoBuscadoDTO);

        //        }
        //        catch (Exception ex)
        //        {
        //            return BadRequest(new { mensaje = $"Ha ocurrido un error {ex.Message}", status = 400 });
        //        }
        //    }
        //    else
        //    {
        //        return base.Conflict(new { mensaje = "El id debe ser positivo", status = 409 });
        //    }
        //}

        [HttpGet("{IdUsuario}")]
        public IActionResult ObtenerProductosPorIdUsuario(int IdUsuario)
        {
            if (IdUsuario > 0)
            {
                try
                {
                    Usuario usuario = this.usuarioService.ObtenerUsuarioPorId(IdUsuario);

                    if (usuario == null)
                    {
                        return NotFound("Usuario no encontrado");
                    }

                    List<Producto> productos = productoService.ObtenerProductosPorIdUsuario(IdUsuario);
                    if (productos == null)
                    {
                        throw new Exception ($"El usuario {IdUsuario} no tiene productos");
                    }

                    List<ProductoDTO> productosDTO = new List<ProductoDTO>();
                    foreach (Producto producto in productos)
                    {
                      ProductoDTO productoDTO = ProductoMapper.MapearADTO(producto);
                      productosDTO.Add(productoDTO);
                    }
                    return base.Ok(new { productosDTO, status = 200 });
                    
                }
                catch (Exception ex)
                {
                    return base.BadRequest(new { mensaje = $"{ex.Message}", status = 400 });
                }
            }
            else
            {
                return base.Conflict(new { mensaje = "El id debe ser positivo", status = 409 });
            }

        }
    }
}
