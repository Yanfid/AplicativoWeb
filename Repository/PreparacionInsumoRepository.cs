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
    public class PreparacionInsumoRepository:ICRUD<PreparacionInsumoModel>
    {
        _dbContext db = new _dbContext();

        public async Task<PreparacionInsumoModel> ActualizarRegistro(PreparacionInsumoModel input)
        {
            db.preparacionInsumos.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<PreparacionInsumoModel> CrearRegistro(PreparacionInsumoModel input)
        {
            await db.preparacionInsumos.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<PreparacionInsumoModel> EliminarRegistro(int id)
        {
            var xd = await db.preparacionInsumos.FindAsync(id);
            db.preparacionInsumos.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<PreparacionInsumoModel>> ListarTodo()
        {
            List<PreparacionInsumoModel> lista = await db.preparacionInsumos
                                         .Include(z => z.Insumos)
                                         .ToListAsync();
            return lista;
        }

        public async Task<PreparacionInsumoModel> ObtenerPorId(int id)
        {
            PreparacionInsumoModel pedido = await db.preparacionInsumos.FindAsync(id);
            return pedido;
        }
    }
}
