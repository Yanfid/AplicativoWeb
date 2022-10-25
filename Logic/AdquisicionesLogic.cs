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
    public class AdquisicionesLogic : ICRUDLogica<AdquisicionesModel>
    {
        AdquisicionesRepository repo = new AdquisicionesRepository();

        public async Task<AdquisicionesModel> ActualizarRegistro(AdquisicionesModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<AdquisicionesModel> CrearRegistro(AdquisicionesModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<AdquisicionesModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<AdquisicionesModel>> ListarTodo()
        {
            List<AdquisicionesModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<AdquisicionesModel> ObtenerPorId(int id)
        {
            AdquisicionesModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
