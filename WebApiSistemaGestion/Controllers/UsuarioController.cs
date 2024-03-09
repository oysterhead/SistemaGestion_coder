using Microsoft.AspNetCore.Mvc;
using WebApiSistemaGestion.Database;
using WebApiSistemaGestion.Models;
using WebApiSistemaGestion.Service;

namespace WebApiSistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private UsuarioService usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }
        [HttpGet("listarusuarios")]
        public List<Usuario> ObtenerListaDeUsuarios()
        {
            return this.usuarioService.ObtenerTodosLosUsuarios();

        }
        [HttpGet("listarusuario/{id}")]
        public ActionResult<string> ObtenerUsuarioPorId(int id)
        {

        }
    }
}
