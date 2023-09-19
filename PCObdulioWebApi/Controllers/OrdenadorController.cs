using Microsoft.AspNetCore.Mvc;
using PCObdulioWebApi.Models;
using PCObdulioWebApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PCObdulioWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenadorController : ControllerBase
    {
        private readonly IRepositorio<Ordenador> _repositorio;


        public OrdenadorController(IRepositorio<Ordenador> repositorio)
        {
            _repositorio = repositorio;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repositorio.ObtenerTodos());
        }




        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var ordenador = _repositorio.Obtener(id);

            if (ordenador == null)
            {
                return NotFound();
            }

            return Ok(ordenador);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Ordenador ordenador)
        {
            _repositorio.Añadir(ordenador);
            return Ok();
        }

        [HttpPut()]
        public IActionResult Put([FromBody] Ordenador ordenador)
        {
            if (_repositorio.Obtener(ordenador.Id) == null)
            {
                return BadRequest(504);
            }

            _repositorio.Actualizar(ordenador);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repositorio.Borrar(id);
            return Ok();
        }
    }
}
