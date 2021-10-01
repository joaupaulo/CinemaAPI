using CinemaAPI.Models;
using CinemaAPI.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Servicos.Repositorio
{
    public class BarRepositorio : IBar
    {
        private readonly IBaseRepository<Bar> _repositorio;

        public BarRepositorio(IBaseRepository<Bar> repositorio)
        {
            _repositorio = repositorio;
        }


        public Bar Pegaritem(int id )
        {
            var item = _repositorio.PegarItem(id);

            return item;
        }

        public IEnumerable<Bar> Listartodos()
        {
            var item = _repositorio.PegarTodos();

            return item;
        }

        public Bar CriarObjeto(Bar item)
        {
            var NovoItem = _repositorio.Inserir(item);

            return NovoItem;
        }

        public Bar Atualizar (Bar item)
        {
            var NovoItem = _repositorio.Inserir(item);

            return NovoItem;
        }

        public void Deletar (int id)
        {
            _repositorio.Delete(id);
        }


    }
}
