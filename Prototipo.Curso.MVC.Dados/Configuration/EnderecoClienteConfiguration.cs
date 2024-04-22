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
    public class EnderecoClienteConfiguration : IEntityTypeConfiguration<EnderecoCliente>
    {
        public void Configure(EntityTypeBuilder<EnderecoCliente> builder)
        {
            builder.ToTable("TB_ENDERECO_CLIENTE");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Bairro)
                .HasColumnType("varchar(50)");
            builder.Property(e => e.CEP)
                .HasColumnType("varchar(20)");
            builder.Property(e => e.Logradouro)
                .HasColumnType("varchar(70)");
            builder.Property(e => e.Numero)
                .HasColumnType("varchar(10)");

            builder.HasOne(e => e.Cliente)
                .WithOne(c => c.Endereco)
                .HasForeignKey<EnderecoCliente>(e => e.ClienteId);
        }
    }
}
