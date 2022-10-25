using Logic.Interface;
using Models;
using Repository;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProductosLogic : ICRUDLogica<ProductosModel>
    {
        ProductosRepository repo = new ProductosRepository();
        public async Task<ProductosModel> ActualizarRegistro(ProductosModel input)
        {
            input = await repo.ActualizarRegistro(input);
            return input;
        }

        public async Task<ProductosModel> CrearRegistro(ProductosModel input)
        {
            input = await repo.CrearRegistro(input);
            return input;
        }

        public async Task<ProductosModel> EliminarRegistro(int id)
        {
            var xd = await repo.EliminarRegistro(id);
            return xd;
        }

        public async Task<List<ProductosModel>> ListarTodo()
        {
            List<ProductosModel> lista = await repo.ListarTodo();
            return lista;
        }

        public async Task<ProductosModel> ObtenerPorId(int id)
        {
            ProductosModel resultado = await repo.ObtenerPorId(id);
            return resultado;
        }
    }
}
