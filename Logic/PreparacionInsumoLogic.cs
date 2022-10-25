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
    public class PreparacionInsumoLogic: ICRUDLogica<PreparacionInsumoModel>
    {
        PreparacionInsumoRepository repo = new PreparacionInsumoRepository();

        public async Task<PreparacionInsumoModel> ActualizarRegistro(PreparacionInsumoModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<PreparacionInsumoModel> CrearRegistro(PreparacionInsumoModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<PreparacionInsumoModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<PreparacionInsumoModel>> ListarTodo()
        {
            List<PreparacionInsumoModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<PreparacionInsumoModel> ObtenerPorId(int id)
        {
            PreparacionInsumoModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
