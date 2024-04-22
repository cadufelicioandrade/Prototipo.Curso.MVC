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
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("TB_FILME");
            builder.HasKey(x => x.Id);

            builder.Property(f => f.TituloFilme)
                .HasColumnType("varchar(70)");
            builder.Property(f => f.ValorDiaria)
                .HasColumnType("decimal(8,2)");// 123456.78
            builder.Property(f => f.Disponivel)
                .HasColumnType("bit")
                .HasDefaultValue(1);
            builder.Property(f => f.Ano)
                .HasColumnType("int");

            builder.HasMany(f => f.ItemLocacoes)
                .WithOne(i => i.Filme)
                .HasForeignKey(i => i.FilmeId);
        }
    }
}
