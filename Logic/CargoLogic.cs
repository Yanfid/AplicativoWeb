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
    public class CargoLogic:ICRUDLogica<CargoModel>
    {
        CargoRepository repo = new CargoRepository();

        public async Task<CargoModel> ActualizarRegistro(CargoModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<CargoModel> CrearRegistro(CargoModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<CargoModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<CargoModel>> ListarTodo()
        {
            List<CargoModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<CargoModel> ObtenerPorId(int id)
        {
            CargoModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
