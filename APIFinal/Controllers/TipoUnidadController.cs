using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUnidadController : ControllerBase
    {
        TipoUnidadLogic tipoUnidadLogic = new TipoUnidadLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<TipoUnidadModel> listaResultados = new List<TipoUnidadModel>();
            listaResultados = await tipoUnidadLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            TipoUnidadModel resultado = new TipoUnidadModel();
            resultado = await tipoUnidadLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(TipoUnidadModel request)
        {
            TipoUnidadModel response = await tipoUnidadLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] TipoUnidadModel request)
        {
            TipoUnidadModel response = await tipoUnidadLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await tipoUnidadLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
