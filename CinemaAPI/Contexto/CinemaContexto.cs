using CinemaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Contexto
{
    public class CinemaContexto : DbContext 
    {


        public CinemaContexto(DbContextOptions<CinemaContexto> options) : base(options)
        {

        }

        public DbSet<Bar> Bar { get; set; }
        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<Ingressos> Ingressos { get; set; }
        public DbSet<Programacao> Programacao { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<CinemaAPI.Models.Cinema> Cinema { get; set; }
    }
}
