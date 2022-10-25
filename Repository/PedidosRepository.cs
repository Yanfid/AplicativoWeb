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
    public class PedidosRepository:ICRUD<PedidosModel>
    {
        _dbContext db = new _dbContext();

        public async Task<PedidosModel> ActualizarRegistro(PedidosModel input)
        {
            db.pedidos.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<PedidosModel> CrearRegistro(PedidosModel input)
        {
            await db.pedidos.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<PedidosModel> EliminarRegistro(int id)
        {
            var xd = await db.pedidos.FindAsync(id);
            db.pedidos.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<PedidosModel>> ListarTodo()
        {
            List<PedidosModel> lista = await db.pedidos
                                         .Include(z => z.Cliente)
                                         .Include(z => z.Estado)
                                         .Include(z => z.Pedido_Producto)
                                         .Include(z => z.Empleado)
                                         .ToListAsync();
            return lista;
        }

        public async Task<PedidosModel> ObtenerPorId(int id)
        {
            PedidosModel pedido = await db.pedidos.FindAsync(id);
            return pedido;
        }
    }
}
