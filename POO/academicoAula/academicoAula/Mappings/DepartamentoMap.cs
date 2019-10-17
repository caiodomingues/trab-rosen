using academicoAula.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace academicoAula.Mappings
{
    public class DepartamentoMap
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {

            builder.HasKey(d => d.DepartamentoID);
            builder.Property(d => d.Nome).IsRequired();
            builder.HasIndex(d => d.Nome).IsUnique();

            builder.HasOne(tc => tc.Instituicao).WithMany(tc => tc.Departamentos);

    

        }
    }
}
