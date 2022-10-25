using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        CategoriaLogic categoriaLogic = new CategoriaLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<CategoriaModel> listaResultados = new List<CategoriaModel>();
            listaResultados = await categoriaLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            CategoriaModel resultado = new CategoriaModel();
            resultado = await categoriaLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(CategoriaModel request)
        {
            CategoriaModel response = await categoriaLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] CategoriaModel request)
        {
            CategoriaModel response = await categoriaLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await categoriaLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
