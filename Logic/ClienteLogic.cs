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
    public class ClienteLogic:ICRUDLogica<ClienteModel>
    {
        ClienteRepository repo = new ClienteRepository();

        public async Task<ClienteModel> ActualizarRegistro(ClienteModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<ClienteModel> CrearRegistro(ClienteModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<ClienteModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<ClienteModel>> ListarTodo()
        {
            List<ClienteModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<ClienteModel> ObtenerPorId(int id)
        {
            ClienteModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
