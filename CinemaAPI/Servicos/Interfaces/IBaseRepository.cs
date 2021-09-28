
using CinemaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Servicos.Interfaces
{
   public interface IBaseRepository<T> where T : BaseEnity
    {
        IEnumerable<T> PegarTodos();
        T PegarItem(int id);
        T Inserir(T item);
        T Atualizar(T item);
        void Delete(int id);

    }
}
