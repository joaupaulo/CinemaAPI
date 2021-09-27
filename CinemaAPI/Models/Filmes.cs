using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Models
{
    public class Filmes
    {
        [Key]
        public int FilmeId { get; set; }
        public string Nome { get; set; }
        public string Atores { get; set; }
        public string Duracao { get; set; }
        public string Sinopse { get; set; }

        public int Avaliacao { get; set; }



    }
}
