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
    public class InsumosRepository:ICRUD<InsumosModel>
    {
        _dbContext db = new _dbContext();

        public async Task<InsumosModel> ActualizarRegistro(InsumosModel input)
        {
            db.insumos.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<InsumosModel> CrearRegistro(InsumosModel input)
        {
            await db.insumos.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<InsumosModel> EliminarRegistro(int id)
        {
            var xd = await db.insumos.FindAsync(id);
            db.insumos.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<InsumosModel>> ListarTodo()
        {
            List<InsumosModel> lista = await db.insumos
                                         .Include(z => z.TipoUnidad)
                                         .ToListAsync();
            return lista;
        }

        public async Task<InsumosModel> ObtenerPorId(int id)
        {
            InsumosModel pedido = await db.insumos.FindAsync(id);
            return pedido;
        }
    }
}
