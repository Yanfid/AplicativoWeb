using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        EstadoLogic estadoLogic = new EstadoLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<EstadoModel> listaResultados = new List<EstadoModel>();
            listaResultados = await estadoLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            EstadoModel resultado = new EstadoModel();
            resultado = await estadoLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(EstadoModel request)
        {
            EstadoModel response = await estadoLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] EstadoModel request)
        {
            EstadoModel response = await estadoLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await estadoLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
