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
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("TB_FUNCIONARIO");
            builder.HasKey(x => x.Id);

            builder.Property(f => f.Nome)
                .HasColumnType("varchar(35)");
            builder.Property(f => f.SobreNome)
                .HasColumnType("varchar(60)");
            builder.Property(f => f.Celular)
                .HasColumnType("varchar(20)");
            builder.Property(f => f.TelFixo)
                .HasColumnType("varchar(20)");
            builder.Property(f => f.CPF)
                .HasColumnType("varchar(11)");
            builder.Property(f => f.Email)
                .HasColumnType("varchar(70)");
            builder.Property(f => f.DataNascimento)
                .HasColumnType("datetime2");
            builder.Property(f => f.DataAdmissao)
                .HasColumnType("datetime2");
            builder.Property(f => f.DataDesligamento)
                .HasColumnType("datetime2");
            builder.Property(f => f.Salario)
                .HasColumnType("decimal(8,2)");

            builder.HasMany(f => f.ItemLocacoes)
                .WithOne(i => i.Funcionario)
                .HasForeignKey(i => i.FuncionarioId);

            builder.HasOne(f => f.Cargo)
                .WithMany(c => c.Funcionarios)
                .HasForeignKey(f => f.CargoId);
        }
    }
}
