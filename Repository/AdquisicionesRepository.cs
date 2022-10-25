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
    public class AdquisicionesRepository:ICRUD<AdquisicionesModel>
    {
        _dbContext db = new _dbContext();

        public async Task<AdquisicionesModel> ActualizarRegistro(AdquisicionesModel input)
        {
            db.adquisiciones.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<AdquisicionesModel> CrearRegistro(AdquisicionesModel input)
        {
            await db.adquisiciones.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<AdquisicionesModel> EliminarRegistro(int id)
        {
            var xd = await db.adquisiciones.FindAsync(id);
            db.adquisiciones.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<AdquisicionesModel>> ListarTodo()
        {
            List<AdquisicionesModel> lista = await db.adquisiciones
                                         .Include(z => z.Insumos)
                                         .ToListAsync();
            return lista;
        }

        public async Task<AdquisicionesModel> ObtenerPorId(int id)
        {
            AdquisicionesModel pedido = await db.adquisiciones.FindAsync(id);
            return pedido;
        }
    }
}
