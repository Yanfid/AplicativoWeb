using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreparacionController : ControllerBase
    {
        PreparacionLogic preparacionLogic = new PreparacionLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<PreparacionModel> listaResultados = new List<PreparacionModel>();
            listaResultados = await preparacionLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            PreparacionModel resultado = new PreparacionModel();
            resultado = await preparacionLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(PreparacionModel request)
        {
            PreparacionModel response = await preparacionLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] PreparacionModel request)
        {
            PreparacionModel response = await preparacionLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await preparacionLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
