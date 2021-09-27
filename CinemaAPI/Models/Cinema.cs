using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Models
{
    public class Cinema
    {
        public int CinemaId { get; set; }
        public string CinemaNome { get; set; }
        public virtual Bar BarId {get; set;}
        public List<Filmes> Filmes { get; set; }
        public List<Ingressos> Ingressos { get; set; }
        public List<Programacao> Programacao { get; set; }
        public List<Sala> Sala { get; set; }









    }
}
