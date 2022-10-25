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
    public class EmpleadoRepository : ICRUD<EmpleadoModel>
    {
        _dbContext db = new _dbContext(); 
        public async Task<EmpleadoModel> ActualizarRegistro(EmpleadoModel input)
        {
            db.empleados.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<EmpleadoModel> CrearRegistro(EmpleadoModel input)
        {
            await db.empleados.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<EmpleadoModel> EliminarRegistro(int id)
        {
            var xd = await db.empleados.FindAsync(id);
            db.empleados.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<EmpleadoModel>> ListarTodo()
        {
            List<EmpleadoModel> lista = await db.empleados
                                         .Include(z => z.Cargo)
                                         .ToListAsync();
            return lista;
        }

        public async Task<EmpleadoModel> ObtenerPorId(int id)
        {
            EmpleadoModel pedido = await db.empleados.FindAsync(id);
            return pedido;
        }
    }
}
