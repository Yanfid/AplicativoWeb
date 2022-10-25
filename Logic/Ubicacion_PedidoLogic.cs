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
    public class Ubicacion_PedidoLogic:ICRUDLogica<Ubicacion_PedidoModel>
    {
        Ubicacion_PedidoRepository repo = new Ubicacion_PedidoRepository();

        public async Task<Ubicacion_PedidoModel> ActualizarRegistro(Ubicacion_PedidoModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<Ubicacion_PedidoModel> CrearRegistro(Ubicacion_PedidoModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<Ubicacion_PedidoModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<Ubicacion_PedidoModel>> ListarTodo()
        {
            List<Ubicacion_PedidoModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<Ubicacion_PedidoModel> ObtenerPorId(int id)
        {
            Ubicacion_PedidoModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
