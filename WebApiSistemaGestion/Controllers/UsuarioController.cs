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
        private CoderContext context;

        public UsuarioController(CoderContext coderContext)
        {
            this.context = coderContext;
        }
        [HttpGet]
        public List<Usuario> ObtenerListaDeUsuarios()
        {
            return this.context.Usuarios.ToList();

        }
    }
}
