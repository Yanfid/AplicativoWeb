using Contraseña;
using Logic.Interface;
using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class UsuarioLoginLogic : ICRUDLogica<UsuarioLoginModel>
    {
        UsuarioRepository repo = new UsuarioRepository();
         public async Task<UsuarioLoginModel>ActualizarRegistro(UsuarioLoginModel input)
        {
            string contraseña = input.Clave;
            input.Clave = Encriptacion.GetSHA256(contraseña);
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<UsuarioLoginModel>CrearRegistro(UsuarioLoginModel input)
        {
            string contraseña = input.Clave;
            input.Clave = Encriptacion.GetSHA256(contraseña);
            input = await repo.CrearRegistro(input);
            return input;   
        }

        public async Task<UsuarioLoginModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<UsuarioLoginModel>>ListarTodo()
        {
            List<UsuarioLoginModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<UsuarioLoginModel> ObtenerPorId(int id)
        {
            UsuarioLoginModel Resultado = await repo.ObtenerPorId(id);
            return Resultado;
        }
    }
}
