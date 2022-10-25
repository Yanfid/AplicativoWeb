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
    public class ComprobanteRepository : ICRUD<ComprobanteModel>
    {
        _dbContext db = new _dbContext();
        public async Task<ComprobanteModel> ActualizarRegistro(ComprobanteModel input)
        {
            db.comprobantes.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<ComprobanteModel> CrearRegistro(ComprobanteModel input)
        {
            await db.comprobantes.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<ComprobanteModel> EliminarRegistro(int id)
        {
            var xd = await db.comprobantes.FindAsync(id);
            db.comprobantes.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<ComprobanteModel>> ListarTodo()
        {
            List<ComprobanteModel> lista = await db.comprobantes
                                                 .Include(z => z.TipoComprobante)
                                                 .ToListAsync();
            return lista;
        }

        public async Task<ComprobanteModel> ObtenerPorId(int id)
        {
            ComprobanteModel pedido = await db.comprobantes.FindAsync(id);
            return pedido;
        }
    }
}
