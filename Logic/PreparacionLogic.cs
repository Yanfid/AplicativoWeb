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
    public class PreparacionLogic: ICRUDLogica<PreparacionModel>
    {
        PreparacionRepository repo = new PreparacionRepository();

        public async Task<PreparacionModel> ActualizarRegistro(PreparacionModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<PreparacionModel> CrearRegistro(PreparacionModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<PreparacionModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<PreparacionModel>> ListarTodo()
        {
            List<PreparacionModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<PreparacionModel> ObtenerPorId(int id)
        {
            PreparacionModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
