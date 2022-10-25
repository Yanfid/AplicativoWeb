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
    public class ComprobanteLogic:ICRUDLogica<ComprobanteModel>
    {
        ComprobanteRepository repo = new ComprobanteRepository();

        public async Task<ComprobanteModel> ActualizarRegistro(ComprobanteModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<ComprobanteModel> CrearRegistro(ComprobanteModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<ComprobanteModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<ComprobanteModel>> ListarTodo()
        {
            List<ComprobanteModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<ComprobanteModel> ObtenerPorId(int id)
        {
            ComprobanteModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
