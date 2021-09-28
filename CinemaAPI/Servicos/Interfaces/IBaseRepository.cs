
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Servicos.Interfaces
{
   public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> PegarTodos();
        T PegarItem(T Id);
        void Inserir(T obj);
        void Atualizar(T obj);
        void Delete(object Id);

    }
}
