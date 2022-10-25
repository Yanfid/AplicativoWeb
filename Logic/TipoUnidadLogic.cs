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
    public class TipoUnidadLogic:ICRUDLogica<TipoUnidadModel>
    {
        TipoUnidadRepository repo = new TipoUnidadRepository();

        public async Task<TipoUnidadModel> ActualizarRegistro(TipoUnidadModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<TipoUnidadModel> CrearRegistro(TipoUnidadModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<TipoUnidadModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<TipoUnidadModel>> ListarTodo()
        {
            List<TipoUnidadModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<TipoUnidadModel> ObtenerPorId(int id)
        {
            TipoUnidadModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
