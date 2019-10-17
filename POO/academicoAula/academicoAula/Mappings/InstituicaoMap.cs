using academicoAula.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace academicoAula.Mappings
{
    public class InstituicaoMap
    {
        public void Configure(EntityTypeBuilder<Instituicao> builder)
        {
            builder.HasKey(d => d.InstituicaoID);
            builder.Property(d => d.Nome).IsRequired();
            builder.HasIndex(d => d.Nome).IsUnique();

            builder.HasMany(tc => tc.Departamentos).WithOne(tc => tc.Instituicao).HasForeignKey(f => f.DepartamentoID);
        
        }
    }
}
