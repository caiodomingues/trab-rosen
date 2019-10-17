using academicoAula.Mappings;
using academicoAula.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace academicoAula.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Instituicao> Instituicao { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
       

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) { }

    }
}