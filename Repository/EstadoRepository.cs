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
    public class EstadoRepository:ICRUD<EstadoModel>
    {
        _dbContext db = new _dbContext();

        public async Task<EstadoModel> ActualizarRegistro(EstadoModel input)
        {
            db.estados.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<EstadoModel> CrearRegistro(EstadoModel input)
        {
            await db.estados.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<EstadoModel> EliminarRegistro(int id)
        {
            var xd = await db.estados.FindAsync(id);
            db.estados.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<EstadoModel>> ListarTodo()
        {
            List<EstadoModel> lista = await db.estados.ToListAsync();
            return lista;
        }

        public async Task<EstadoModel> ObtenerPorId(int id)
        {
            EstadoModel pedido = await db.estados.FindAsync(id);
            return pedido;
        }
    }
}
