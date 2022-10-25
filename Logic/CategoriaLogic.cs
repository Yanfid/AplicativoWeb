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
    public class CategoriaLogic : ICRUDLogica<CategoriaModel>
    {
        CategoriaRepository repo = new CategoriaRepository();
        public async Task<CategoriaModel> ActualizarRegistro(CategoriaModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<CategoriaModel> CrearRegistro(CategoriaModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<CategoriaModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<CategoriaModel>> ListarTodo()
        {
            List<CategoriaModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<CategoriaModel> ObtenerPorId(int id)
        {
            CategoriaModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
