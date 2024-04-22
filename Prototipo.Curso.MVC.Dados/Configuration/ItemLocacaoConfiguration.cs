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
    public class ItemLocacaoConfiguration : IEntityTypeConfiguration<ItemLocacao>
    {
        public void Configure(EntityTypeBuilder<ItemLocacao> builder)
        {
            builder.ToTable("TB_ITEM_LOCACAO");
            builder.HasKey(x => x.Id);

            builder.Property(i => i.Diarias)
                .HasColumnType("int");
            builder.Property(i => i.ValorDiaria)
                .HasColumnType("decimal(8,2)");

            builder.HasMany(i => i.Locacoes)
                .WithOne(l => l.ItemLocacao)
                .HasForeignKey(l => l.ItemLocacaoId);
        }
    }
}
