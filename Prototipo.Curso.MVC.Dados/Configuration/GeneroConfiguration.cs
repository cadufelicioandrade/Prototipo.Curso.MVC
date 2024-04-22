using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prototipo.Curso.MVC.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Curso.MVC.Dados.Configuration
{
    public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("TB_GENERO");
            builder.HasKey(g => g.Id);

            builder.Property(g => g.NomeGenero)
                .HasColumnType("varchar(50)");

            builder.HasMany(g => g.Filmes)
                .WithOne(f => f.Genero)
                .HasForeignKey(f => f.GeneroId);
        }
    }
}
