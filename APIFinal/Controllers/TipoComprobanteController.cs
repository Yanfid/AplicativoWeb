using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoComprobanteController : ControllerBase
    {
        TipoComprobanteLogic tipoComprobanteLogic = new TipoComprobanteLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<TipoComprobanteModel> listaResultados = new List<TipoComprobanteModel>();
            listaResultados = await tipoComprobanteLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            TipoComprobanteModel resultado = new TipoComprobanteModel();
            resultado = await tipoComprobanteLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(TipoComprobanteModel request)
        {
            TipoComprobanteModel response = await tipoComprobanteLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] TipoComprobanteModel request)
        {
            TipoComprobanteModel response = await tipoComprobanteLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await tipoComprobanteLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
