using CinemaAPI.Contexto;
using CinemaAPI.Models;
using CinemaAPI.Servicos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Servicos.Repositorio
{
    public class BaseRepositorio<T> : IBaseRepository<T> where T : BaseEnity
    {

        protected readonly CinemaContexto _CinemaContextos;
        private DbSet<T> Tabelas;
       
        public BaseRepositorio(CinemaContexto CinemaContexto)
        {
            this._CinemaContextos = CinemaContexto;
            Tabelas = _CinemaContextos.Set<T>();
        }

        public T Atualizar(T item)
        {
            var UpdateItem = Tabelas.Where(x => x.Id == item.Id).FirstOrDefault();

            if(UpdateItem != null)
            {
                try
                {
                    Tabelas.Add(item);
                    _CinemaContextos.SaveChanges();
                }

                catch (Exception)
                {
                    throw new ArgumentNullException("Item nulo");
                }

            } else
            {
                return null;

            }

            return item;
        }

        public void Delete(int id)
        {
            var DeleteItem = Tabelas.Where(x => x.Id == id).FirstOrDefault();

            if(DeleteItem != null)
            {

                try
                {
                    Tabelas.Remove(DeleteItem);
                    _CinemaContextos.SaveChanges();
                }

                catch (Exception)
                {
                    throw new ArgumentNullException("Item nulo");
                }


            }

        }

        public T Inserir(T item)
        {
           try
            {
              Tabelas.Add(item);
              _CinemaContextos.SaveChanges();
            } 
            
            catch(Exception)
            {
                throw new ArgumentNullException("Item nulo");
            }

            return item;
        }

        public T PegarItem(int id)
        {
            var PegarItem = Tabelas.Where(x => x.Id == id).FirstOrDefault();

            return PegarItem;
        }

        public IEnumerable<T> PegarTodos()
        {
            return Tabelas.ToList();
        }
    }
}
