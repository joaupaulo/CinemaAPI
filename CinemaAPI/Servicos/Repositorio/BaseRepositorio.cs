using CinemaAPI.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Servicos.Repositorio
{
    public class BaseRepositorio<T> : IBaseRepository<T> where T : class
    {
        public void Atualizar(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(object Id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(T obj)
        {
            throw new NotImplementedException();
        }

        public T PegarItem(T Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> PegarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
