using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdquisicionesController : ControllerBase
    {
        AdquisicionesLogic adquisicionesLogic = new AdquisicionesLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<AdquisicionesModel> listaResultados = new List<AdquisicionesModel>();
            listaResultados = await adquisicionesLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            AdquisicionesModel resultado = new AdquisicionesModel();
            resultado = await adquisicionesLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(AdquisicionesModel request)
        {
            AdquisicionesModel response = await adquisicionesLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] AdquisicionesModel request)
        {
            AdquisicionesModel response = await adquisicionesLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await adquisicionesLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
