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
    public class Pedido_ProductoRepository:ICRUD<Pedido_ProductoModel>
    {
        _dbContext db = new _dbContext();

        public async Task<Pedido_ProductoModel> ActualizarRegistro(Pedido_ProductoModel input)
        {
            db.pedido_Productos.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<Pedido_ProductoModel> CrearRegistro(Pedido_ProductoModel input)
        {
            await db.pedido_Productos.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<Pedido_ProductoModel> EliminarRegistro(int id)
        {
            var xd = await db.pedido_Productos.FindAsync(id);
            db.pedido_Productos.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<Pedido_ProductoModel>> ListarTodo()
        {
            List<Pedido_ProductoModel> lista = await db.pedido_Productos
                                         .Include(z => z.Productos)
                                         .ToListAsync();
            return lista;
        }

        public async Task<Pedido_ProductoModel> ObtenerPorId(int id)
        {
            Pedido_ProductoModel pedido = await db.pedido_Productos.FindAsync(id);
            return pedido;
        }
    }
}
