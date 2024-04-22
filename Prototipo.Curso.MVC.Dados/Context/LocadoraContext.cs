using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo.Curso.MVC.Dados.Configuration;
using Prototipo.Curso.MVC.Dominio.Modelos;

namespace Prototipo.Curso.MVC.Dados.Context
{
    public class LocadoraContext : DbContext
    {
        public LocadoraContext(DbContextOptions<LocadoraContext> options) : base(options) {}

        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Diretor> Diretor { get; set; }
        public DbSet<EnderecoCliente> EnderecoCliente { get; set; }
        public DbSet<EnderecoFuncionario> EnderecoFuncionario { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<ItemLocacao> ItemLocacao { get; set; }
        public DbSet<Locacao> Locacao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CidadeConfiguration());
            modelBuilder.ApplyConfiguration(new CargoConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new DiretorConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoClienteConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoFuncionarioConfiguration());
            modelBuilder.ApplyConfiguration(new EstadoConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
            modelBuilder.ApplyConfiguration(new GeneroConfiguration());
            modelBuilder.ApplyConfiguration(new ItemLocacaoConfiguration());
            modelBuilder.ApplyConfiguration(new LocacaoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
