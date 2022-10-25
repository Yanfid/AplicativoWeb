using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobanteController : ControllerBase
    {
        ComprobanteLogic comprobanteLogic = new ComprobanteLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<ComprobanteModel> listaResultados = new List<ComprobanteModel>();
            listaResultados = await comprobanteLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            ComprobanteModel resultado = new ComprobanteModel();
            resultado = await comprobanteLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(ComprobanteModel request)
        {
            ComprobanteModel response = await comprobanteLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] ComprobanteModel request)
        {
            ComprobanteModel response = await comprobanteLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await comprobanteLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
