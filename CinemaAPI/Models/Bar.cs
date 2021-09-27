using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Models
{
    public class Bar
    {
        [Key]
        public int CardapioId { get; set; }
        public string Comida { get; set; }
        public string Bebida { get; set; }
        public string Combo { get; set; }
        public string Doce { get; set; }

        public string Sobremesa { get; set; }


    }
}
