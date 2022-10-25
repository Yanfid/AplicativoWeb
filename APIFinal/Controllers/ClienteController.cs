using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        ClienteLogic clienteLogic = new ClienteLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<ClienteModel> listaResultados = new List<ClienteModel>();
            listaResultados = await clienteLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            ClienteModel resultado = new ClienteModel();
            resultado = await clienteLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(ClienteModel request)
        {
            ClienteModel response = await clienteLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] ClienteModel request)
        {
            ClienteModel response = await clienteLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await clienteLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
