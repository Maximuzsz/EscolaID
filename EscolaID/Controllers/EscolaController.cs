using EscolaID.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EscolaID.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<EscolaModel>> BuscarTodasEscolas()
        {
            return Ok();
        }
    }
}
