using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ubicacion_PedidoController : ControllerBase
    {
        Ubicacion_PedidoLogic ubicacion_PedidoLogic = new Ubicacion_PedidoLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<Ubicacion_PedidoModel> listaResultados = new List<Ubicacion_PedidoModel>();
            listaResultados = await ubicacion_PedidoLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            Ubicacion_PedidoModel resultado = new Ubicacion_PedidoModel();
            resultado = await ubicacion_PedidoLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(Ubicacion_PedidoModel request)
        {
            Ubicacion_PedidoModel response = await ubicacion_PedidoLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] Ubicacion_PedidoModel request)
        {
            Ubicacion_PedidoModel response = await ubicacion_PedidoLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await ubicacion_PedidoLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
