//using Logic;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace APIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioLoginController : ControllerBase
    {
        //UsuarioLoginLogic usuarioLogin = new UsuarioLoginLogic();
        UsuarioLoginLogic usuarioLogin = new UsuarioLoginLogic();
        UsuarioLoginModel resultado = new UsuarioLoginModel();

        [HttpGet]
        public async Task<IActionResult> get()
        {
            List<UsuarioLoginModel> usuarioLoginModels = new List<UsuarioLoginModel>();
            usuarioLoginModels = await usuarioLogin.ListarTodo();
            return Ok(usuarioLoginModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getId(int id)
        {
            
            resultado = await usuarioLogin.ObtenerPorId(id);
            return Ok(resultado);
        }

        [HttpPost]
        public async Task<IActionResult> post(UsuarioLoginModel request)
        {
            UsuarioLoginModel response = await usuarioLogin.CrearRegistro(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> put([FromBody] UsuarioLoginModel request)
        {
            UsuarioLoginModel response = await usuarioLogin.ActualizarRegistro(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> delete(int id)
        {
            var response = await usuarioLogin.EliminarRegistro(id);
            return Ok(response);
        }
    }
}
