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
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("TB_ESTADO");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.NomeEstado)
                .HasColumnType("varchar(50)");

            builder.HasMany(e => e.Cidades)
                .WithOne(c => c.Estado)
                .HasForeignKey(c => c.EstadoId);
        }
    }
}
