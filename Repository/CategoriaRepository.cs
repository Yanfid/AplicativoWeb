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
    public class CategoriaRepository:ICRUD<CategoriaModel>
    {
        _dbContext db = new _dbContext();

        public async Task<CategoriaModel> ActualizarRegistro(CategoriaModel input)
        {
            db.categorias.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<CategoriaModel> CrearRegistro(CategoriaModel input)
        {
            await db.categorias.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<CategoriaModel> EliminarRegistro(int id)
        {
            var xd = await db.categorias.FindAsync(id);
            db.categorias.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<CategoriaModel>> ListarTodo()
        {
            List<CategoriaModel> lista = await db.categorias.ToListAsync();
            return lista;
        }

        public async Task<CategoriaModel> ObtenerPorId(int id)
        {
            CategoriaModel cargo = await db.categorias.FindAsync(id);
            return cargo;
        }
    }
}
