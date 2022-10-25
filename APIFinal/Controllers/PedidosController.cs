using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        PedidosLogic pedidosLogic = new PedidosLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<PedidosModel> listaResultados = new List<PedidosModel>();
            listaResultados = await pedidosLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            PedidosModel resultado = new PedidosModel();
            resultado = await pedidosLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(PedidosModel request)
        {
            PedidosModel response = await pedidosLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] PedidosModel request)
        {
            PedidosModel response = await pedidosLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await pedidosLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
