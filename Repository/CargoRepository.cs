using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Context;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CargoRepository:ICRUD<CargoModel>
    {
        _dbContext db = new _dbContext();

        public async Task<CargoModel> ActualizarRegistro(CargoModel input)
        {
            db.cargos.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<CargoModel> CrearRegistro(CargoModel input)
        {
            await db.cargos.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<CargoModel> EliminarRegistro(int id)
        {
            var xd = await db.cargos.FindAsync(id);
            db.cargos.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<CargoModel>> ListarTodo()
        {
            List<CargoModel> lista = await db.cargos.ToListAsync();
            return lista;
        }

        public async Task<CargoModel> ObtenerPorId(int id)
        {
            CargoModel pedido = await db.cargos.FindAsync(id);
            return pedido;
        }
    }
}
