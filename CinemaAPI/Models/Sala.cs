using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Models
{
    public class Sala : BaseEnity
    {
      
        public string Lado { get; set; }
        public int NumeroPoltrona { get; set; }
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
    }
}
