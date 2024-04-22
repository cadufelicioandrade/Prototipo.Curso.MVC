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
    public class DiretorConfiguration : IEntityTypeConfiguration<Diretor>
    {
        public void Configure(EntityTypeBuilder<Diretor> builder)
        {
            builder.ToTable("TB_DIRETOR");
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Nome)
                .HasColumnType("varchar(50)");

            builder.HasMany(d => d.Filmes)
                .WithOne(d => d.Diretor)
                .HasForeignKey(d => d.DiretorId);
        }
    }
}
