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
    public class LocacaoConfiguration : IEntityTypeConfiguration<Locacao>
    {
        public void Configure(EntityTypeBuilder<Locacao> builder)
        {
            builder.ToTable("TB_LOCACAO");
            builder.HasKey(x => x.Id);

            builder.Property(l => l.ValorTotal)
                .HasColumnType("decimal(8,2)");
            builder.Property(l => l.MultaAtraso)
                .HasColumnType("decimal(8,2)");
            builder.Property(l => l.DataLocacao)
                .HasColumnType("datetime2");
            builder.Property(l => l.DataDevolucao)
                .HasColumnType("datetime2");
        }
    }
}
