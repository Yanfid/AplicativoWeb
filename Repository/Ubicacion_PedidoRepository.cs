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
    public class Ubicacion_PedidoRepository:ICRUD<Ubicacion_PedidoModel>
    {
        _dbContext db = new _dbContext();

        public async Task<Ubicacion_PedidoModel> ActualizarRegistro(Ubicacion_PedidoModel input)
        {
            db.ubicacion_Pedidos.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<Ubicacion_PedidoModel> CrearRegistro(Ubicacion_PedidoModel input)
        {
            await db.ubicacion_Pedidos.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<Ubicacion_PedidoModel> EliminarRegistro(int id)
        {
            var xd = await db.ubicacion_Pedidos.FindAsync(id);
            db.ubicacion_Pedidos.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<Ubicacion_PedidoModel>> ListarTodo()
        {
            List<Ubicacion_PedidoModel> lista = await db.ubicacion_Pedidos
                                         .Include(z => z.Cliente)
                                         .ToListAsync();
            return lista;
        }

        public async Task<Ubicacion_PedidoModel> ObtenerPorId(int id)
        {
            Ubicacion_PedidoModel pedido = await db.ubicacion_Pedidos.FindAsync(id);
            return pedido;
        }
    }
}
