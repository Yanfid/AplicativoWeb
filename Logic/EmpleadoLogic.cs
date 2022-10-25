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
    public class EmpleadoLogic:ICRUDLogica<EmpleadoModel>
    {
        EmpleadoRepository repo = new EmpleadoRepository();

        public async Task<EmpleadoModel> ActualizarRegistro(EmpleadoModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<EmpleadoModel> CrearRegistro(EmpleadoModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<EmpleadoModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<EmpleadoModel>> ListarTodo()
        {
            List<EmpleadoModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<EmpleadoModel> ObtenerPorId(int id)
        {
            EmpleadoModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
