using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Models
{
    public class Bar : BaseEnity
    {
        public string Comida { get; set; }
        public string Bebida { get; set; }
        public string Combo { get; set; }
        public string Doce { get; set; }

        public string Sobremesa { get; set; }

        public int CinemaId { get; set; }

        public Cinema Cinema { get; set; }



    }
}
