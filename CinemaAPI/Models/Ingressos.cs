using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Models
{
    public class Ingressos : BaseEnity
    {
        public int ValorIntegral { get; set; }
        public int ValorMeia { get; set; }
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }




    }
}
