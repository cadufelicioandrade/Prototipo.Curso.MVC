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
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("TB_CARGO");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Administrador)
                .HasColumnType("bit")
                .HasDefaultValue(0);
            builder.Property(c => c.Descricao)
                .HasColumnType("varchar(100)");

        }
    }
}
