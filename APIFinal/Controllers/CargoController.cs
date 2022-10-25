using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        CargoLogic cargoLogic = new CargoLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<CargoModel> listaResultados = new List<CargoModel>();
            listaResultados = await cargoLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            CargoModel resultado = new CargoModel();
            resultado = await cargoLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(CargoModel request)
        {
            CargoModel response = await cargoLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] CargoModel request)
        {
            CargoModel response = await cargoLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await cargoLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
