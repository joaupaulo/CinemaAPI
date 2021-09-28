using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Models
{
    public class Programacao : BaseEnity
    {
       
       public DateTime DataLancamento { get; set; }
       public DateTime FilmeHoje { get; set; }
       public DateTime FilmeSemana { get; set; }
       public int CinemaId { get; set; }
       public Cinema Cinema { get; set; }

    }
}
