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
    public class EstadoLogic:ICRUDLogica<EstadoModel>
    {
        EstadoRepository repo = new EstadoRepository();

        public async Task<EstadoModel> ActualizarRegistro(EstadoModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<EstadoModel> CrearRegistro(EstadoModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<EstadoModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<EstadoModel>> ListarTodo()
        {
            List<EstadoModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<EstadoModel> ObtenerPorId(int id)
        {
            EstadoModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
