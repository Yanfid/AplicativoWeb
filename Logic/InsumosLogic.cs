using Logic.Interface;
using Models;
using Repository;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class InsumosLogic : ICRUDLogica<InsumosModel>
    {
        InsumosRepository repo = new InsumosRepository();
        public async Task<InsumosModel> ActualizarRegistro(InsumosModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<InsumosModel> CrearRegistro(InsumosModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<InsumosModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<InsumosModel>> ListarTodo()
        {
            List<InsumosModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<InsumosModel> ObtenerPorId(int id)
        {
            InsumosModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
