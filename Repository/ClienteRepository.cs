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
    public class ClienteRepository:ICRUD<ClienteModel>
    {
        _dbContext db = new _dbContext();

        public async Task<ClienteModel> ActualizarRegistro(ClienteModel input)
        {
            db.clientes.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<ClienteModel> CrearRegistro(ClienteModel input)
        {
            await db.clientes.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<ClienteModel> EliminarRegistro(int id)
        {
            var xd = await db.clientes.FindAsync(id);
            db.clientes.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<ClienteModel>> ListarTodo()
        {
            List<ClienteModel> lista = await db.clientes.ToListAsync();
            return lista;
        }

        public async Task<ClienteModel> ObtenerPorId(int id)
        {
            ClienteModel pedido = await db.clientes.FindAsync(id);
            return pedido;
        }
    }
}
