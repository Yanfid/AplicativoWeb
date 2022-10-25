using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Context;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UsuarioRepository:ICRUD<UsuarioLoginModel>
    {
        _dbContext db = new _dbContext();
        public async Task<UsuarioLoginModel> ActualizarRegistro(UsuarioLoginModel input)
        {
            db.usuarioLogin.Update(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<UsuarioLoginModel> CrearRegistro(UsuarioLoginModel input)
        {
            await db.usuarioLogin.AddAsync(input);
            await db.SaveChangesAsync();
            return input;
        }

        public async Task<UsuarioLoginModel> EliminarRegistro(int id)
        {
            var xd = await db.usuarioLogin.FindAsync(id);
            db.usuarioLogin.Remove(xd);
            await db.SaveChangesAsync();
            return xd;
        }

        public async Task<List<UsuarioLoginModel>> ListarTodo()
        {
            List<UsuarioLoginModel> lista = await db.usuarioLogin
                                                    .Include(z=>z.Empleado)
                                                    .Include(z => z.Empleado.Cargo)
                                                    .ToListAsync();
            return lista;
        }

        public async Task<UsuarioLoginModel> ObtenerPorId(int id)
        {
            UsuarioLoginModel usuario = await db.usuarioLogin.FirstAsync();
            return usuario;
        }
    }
}
