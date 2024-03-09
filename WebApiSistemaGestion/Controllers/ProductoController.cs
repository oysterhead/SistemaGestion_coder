using Microsoft.AspNetCore.Mvc;

namespace WebApiSistemaGestion.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class ProductoController : Controller
    {
        [HttpGet]
        public ActionResult<string> Index()
        {
            return "Productos!";
        }
    }
}
