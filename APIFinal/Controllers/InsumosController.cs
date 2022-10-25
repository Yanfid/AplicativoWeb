using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsumosController : ControllerBase
    {
        InsumosLogic insumosLogic = new InsumosLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<InsumosModel> listaResultados = new List<InsumosModel>();
            listaResultados = await insumosLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            InsumosModel resultado = new InsumosModel();
            resultado = await insumosLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(InsumosModel request)
        {
            InsumosModel response = await insumosLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] InsumosModel request)
        {
            InsumosModel response = await insumosLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await insumosLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
