using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        EmpleadoLogic empleadoLogic = new EmpleadoLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<EmpleadoModel> listaResultados = new List<EmpleadoModel>();
            listaResultados = await empleadoLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            EmpleadoModel resultado = new EmpleadoModel();
            resultado = await empleadoLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(EmpleadoModel request)
        {
            EmpleadoModel response = await empleadoLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] EmpleadoModel request)
        {
            EmpleadoModel response = await empleadoLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await empleadoLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
