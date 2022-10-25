using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        ProductosLogic productosLogic = new ProductosLogic();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<ProductosModel> listaResultados = new List<ProductosModel>();
            listaResultados = await productosLogic.ListarTodo();
            return Ok(listaResultados);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            ProductosModel resultado = new ProductosModel();
            resultado = await productosLogic.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(ProductosModel request)
        {
            ProductosModel response = await productosLogic.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] ProductosModel request)
        {
            ProductosModel response = await productosLogic.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await productosLogic.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
