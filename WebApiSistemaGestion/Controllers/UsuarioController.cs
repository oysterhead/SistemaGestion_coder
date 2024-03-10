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
    public class UsuarioController : Controller
    {
        private UsuarioService usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }
        [HttpGet("Usuarios")]
        public List<Usuario> ObtenerListaDeUsuarios()
        {
            return this.usuarioService.ObtenerTodosLosUsuarios();

        }
        [HttpGet("{id}")]
        public IActionResult ObtenerUsuarioPorId(int id)
        {
            if (id > 0)
            {
                try
                {
                    Usuario usuarioBuscado = this.usuarioService.ObtenerUsuarioPorId(id);
                    if (usuarioBuscado == null)
                    {
                        return base.Conflict(new { mensaje = "Usuario no encontrado", status = 400 });
                    }
                    UsuarioDTO usuarioBuscadoDTO = UsuarioMapper.MapearADTO(usuarioBuscado);
                    return base.Ok(usuarioBuscadoDTO);

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
        [HttpGet("{nombreUsuario}")]
        public IActionResult ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            if (!string.IsNullOrEmpty(nombreUsuario))
            {
                try
                {
                    Usuario usuarioBuscado = this.usuarioService.ObtenerUsuarioPorNombre(nombreUsuario);
                    if (usuarioBuscado == null) 
                    {
                        return base.Conflict(new { mensaje = "Usuario no encontrado", status = 400 });
                    }
                    UsuarioDTO usuarioBuscadoDTO = UsuarioMapper.MapearADTO(usuarioBuscado);
                    return base.Ok(usuarioBuscadoDTO);

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

        [HttpGet("{usuario}/{password}")]
        public IActionResult ObtenerUsuarioPorUsuarioYPassword (string usuario, string password)
        {
            Usuario usuarioBuscado = this.usuarioService.ObtenerUsuarioPorUsuarioYPassword(usuario, password);
            if (usuarioBuscado == null)
            {
                return base.Conflict(new { mensaje = "Usuario no encontrado", status = 400 });
            }
            else
            {
                return base.Conflict(new { mensaje = "El id debe ser positivo", status = 409 });
            }
            UsuarioDTO usuarioBuscadoDTO = UsuarioMapper.MapearADTO(usuarioBuscado);
            return base.Ok(usuarioBuscadoDTO);
        }

        [HttpPost]
        public IActionResult AgregarNuevoUsuario([FromBody] UsuarioDTO usuarioDTO)
        {
            if (this.usuarioService.AgregarUsuario(usuarioDTO))
            {
                return base.Ok(new { mensaje = "Usuario agregado exitosamente", status = 200, usuarioDTO });
            }
            else { return base.Conflict(new { mensaje = "Ha ocurrido un problema al agregar un usuario", status = 200 }); }
        }

        [HttpPut("{Id}")]
        public IActionResult ModificarUsuarioPorId(int Id, [FromBody] UsuarioDTO usuarioDTO)
        {
            if (Id > 0)
            {
                try
                {
                    this.usuarioService.ModificarUsuario(Id, usuarioDTO);
                    return base.Ok(new { mensaje = $"Producto con Id {Id} actualizado con éxito", status = 200, usuarioDTO });

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
