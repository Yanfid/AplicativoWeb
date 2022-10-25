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
    public class PreparacionRepository:ICRUD<PreparacionModel>
    {
        _dbContext db = new _dbContext();

        public async Task<PreparacionModel> ActualizarRegistro(PreparacionModel input)
        {
            db.preparaciones.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<PreparacionModel> CrearRegistro(PreparacionModel input)
        {
            await db.preparaciones.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<PreparacionModel> EliminarRegistro(int id)
        {
            var xd = await db.preparaciones.FindAsync(id);
            db.preparaciones.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<PreparacionModel>> ListarTodo()
        {
            List<PreparacionModel> lista = await db.preparaciones
                                         .Include(z => z.PreparacionInsumo)
                                         .ToListAsync();
            return lista;
        }

        public async Task<PreparacionModel> ObtenerPorId(int id)
        {
            PreparacionModel pedido = await db.preparaciones.FindAsync(id);
            return pedido;
        }
    }
}
