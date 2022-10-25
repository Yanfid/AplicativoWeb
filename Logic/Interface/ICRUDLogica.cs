using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interface
{
    public interface ICRUDLogica<T>
    {
        Task<List<T>> ListarTodo();
        Task<T> ObtenerPorId(int id);
        Task<T> CrearRegistro(T input);
        Task<T> ActualizarRegistro(T input);
        Task<T> EliminarRegistro(int id);
    }
}
