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
    public class TipoUnidadRepository:ICRUD<TipoUnidadModel>
    {
        _dbContext db = new _dbContext();

        public async Task<TipoUnidadModel> ActualizarRegistro(TipoUnidadModel input)
        {
            db.tipoUnidades.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<TipoUnidadModel> CrearRegistro(TipoUnidadModel input)
        {
            await db.tipoUnidades.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<TipoUnidadModel> EliminarRegistro(int id)
        {
            var xd = await db.tipoUnidades.FindAsync(id);
            db.tipoUnidades.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<TipoUnidadModel>> ListarTodo()
        {
            List<TipoUnidadModel> lista = await db.tipoUnidades.ToListAsync();
            return lista;
        }

        public async Task<TipoUnidadModel> ObtenerPorId(int id)
        {
            TipoUnidadModel pedido = await db.tipoUnidades.FindAsync(id);
            return pedido;
        }
    }
}
