using CinemaAPI.Contexto;
using CinemaAPI.Servicos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Servicos.Repositorio
{
    public class BaseRepositorio<T> : IBaseRepository<T> where T : class
    {

        private readonly CinemaContexto _CinemaContextos;

       
        public BaseRepositorio(CinemaContexto CinemaContexto)
        {
            _CinemaContextos = CinemaContexto;
        }


        public void Atualizar(T obj)
        {
            if (obj == null) throw new ArgumentNullException("Valor nulo");

        

        }

        public void Delete(T Id)
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
