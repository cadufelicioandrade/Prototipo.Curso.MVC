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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {

            builder.ToTable("TB_CLIENTE");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(35)");
            builder.Property(c => c.SobreNome)
                .HasColumnType("varchar(60)");
            builder.Property(c => c.Celular)
                .HasColumnType("varchar(20)");
            builder.Property(c => c.TelFixo)
                .HasColumnType("varchar(20)");
            builder.Property(c => c.CPF)
                .HasColumnType("varchar(11)");
            builder.Property(c => c.Email)
                .HasColumnType("varchar(70)");
            builder.Property(c => c.DataNascimento)
                .HasColumnType("datetime2");

        }
    }
}
