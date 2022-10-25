using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreparacionInsumoController : ControllerBase
    {
        PreparacionInsumoLogic preparacionInsumoLogic = new PreparacionInsumoLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<PreparacionInsumoModel> listaResultados = new List<PreparacionInsumoModel>();
            listaResultados = await preparacionInsumoLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            PreparacionInsumoModel resultado = new PreparacionInsumoModel();
            resultado = await preparacionInsumoLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(PreparacionInsumoModel request)
        {
            PreparacionInsumoModel response = await preparacionInsumoLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] PreparacionInsumoModel request)
        {
            PreparacionInsumoModel response = await preparacionInsumoLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await preparacionInsumoLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
