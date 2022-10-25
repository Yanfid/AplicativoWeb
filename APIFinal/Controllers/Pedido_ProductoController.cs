using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pedido_ProductoController : ControllerBase
    {
        Pedido_ProductoLogic pedido_ProductoLogic = new Pedido_ProductoLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<Pedido_ProductoModel> listaResultados = new List<Pedido_ProductoModel>();
            listaResultados = await pedido_ProductoLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            Pedido_ProductoModel resultado = new Pedido_ProductoModel();
            resultado = await pedido_ProductoLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(Pedido_ProductoModel request)
        {
            Pedido_ProductoModel response = await pedido_ProductoLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] Pedido_ProductoModel request)
        {
            Pedido_ProductoModel response = await pedido_ProductoLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await pedido_ProductoLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
