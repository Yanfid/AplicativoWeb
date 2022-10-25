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
    public class TipoComprobanteRepository:ICRUD<TipoComprobanteModel>
    {
        _dbContext db = new _dbContext();

        public async Task<TipoComprobanteModel> ActualizarRegistro(TipoComprobanteModel input)
        {
            db.tipoComprobantes.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<TipoComprobanteModel> CrearRegistro(TipoComprobanteModel input)
        {
            await db.tipoComprobantes.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<TipoComprobanteModel> EliminarRegistro(int id)
        {
            var xd = await db.tipoComprobantes.FindAsync(id);
            db.tipoComprobantes.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<TipoComprobanteModel>> ListarTodo()
        {
            List<TipoComprobanteModel> lista = await db.tipoComprobantes.ToListAsync();
            return lista;
        }

        public async Task<TipoComprobanteModel> ObtenerPorId(int id)
        {
            TipoComprobanteModel pedido = await db.tipoComprobantes.FindAsync(id);
            return pedido;
        }
    }
}
