﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prototipo.Curso.MVC.Dados.Context;

#nullable disable

namespace Prototipo.Curso.MVC.Dados.Migrations
{
    [DbContext(typeof(LocadoraContext))]
    [Migration("20240429024727_Primeira Migracao")]
    partial class PrimeiraMigracao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Administrador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TB_CARGO", (string)null);
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("NomeCidade")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("TB_CIDADE", (string)null);
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(35)");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("TelFixo")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("TB_CLIENTE", (string)null);
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Diretor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeDiretor")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TB_DIRETOR", (string)null);
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.EnderecoCliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("TB_ENDERECO_CLIENTE", (string)null);
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.EnderecoFuncionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("FuncionarioId")
                        .IsUnique();

                    b.ToTable("TB_ENDERECO_FUNCIONARIO", (string)null);
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeEstado")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TB_ESTADO", (string)null);
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("DiretorId")
                        .HasColumnType("int");

                    b.Property<bool>("Disponivel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("TituloFilme")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<decimal>("ValorDiaria")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("DiretorId");

                    b.HasIndex("GeneroId");

                    b.ToTable("TB_FILME", (string)null);
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<int>("CargoId")
                        .HasColumnType("int");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataDesligamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(35)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("TelFixo")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.ToTable("TB_FUNCIONARIO", (string)null);
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeGenero")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TB_GENERO", (string)null);
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.ItemLocacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("Diarias")
                        .HasColumnType("int");

                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<int>("LocacaoId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorDiaria")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FilmeId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("LocacaoId");

                    b.ToTable("TB_ITEM_LOCACAO", (string)null);
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MultaAtraso")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.ToTable("TB_LOCACAO", (string)null);
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Cidade", b =>
                {
                    b.HasOne("Prototipo.Curso.MVC.Dominio.Modelos.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.EnderecoCliente", b =>
                {
                    b.HasOne("Prototipo.Curso.MVC.Dominio.Modelos.Cidade", "Cidade")
                        .WithMany("EnderecoCliente")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prototipo.Curso.MVC.Dominio.Modelos.Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("Prototipo.Curso.MVC.Dominio.Modelos.EnderecoCliente", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.EnderecoFuncionario", b =>
                {
                    b.HasOne("Prototipo.Curso.MVC.Dominio.Modelos.Cidade", "Cidade")
                        .WithMany("EnderecoFuncionario")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prototipo.Curso.MVC.Dominio.Modelos.Funcionario", "Funcionario")
                        .WithOne("EnderecoFuncionario")
                        .HasForeignKey("Prototipo.Curso.MVC.Dominio.Modelos.EnderecoFuncionario", "FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Filme", b =>
                {
                    b.HasOne("Prototipo.Curso.MVC.Dominio.Modelos.Diretor", "Diretor")
                        .WithMany("Filmes")
                        .HasForeignKey("DiretorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prototipo.Curso.MVC.Dominio.Modelos.Genero", "Genero")
                        .WithMany("Filmes")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diretor");

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Funcionario", b =>
                {
                    b.HasOne("Prototipo.Curso.MVC.Dominio.Modelos.Cargo", "Cargo")
                        .WithMany("Funcionarios")
                        .HasForeignKey("CargoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.ItemLocacao", b =>
                {
                    b.HasOne("Prototipo.Curso.MVC.Dominio.Modelos.Cliente", "Cliente")
                        .WithMany("ItemLocacoes")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prototipo.Curso.MVC.Dominio.Modelos.Filme", "Filme")
                        .WithMany("ItemLocacoes")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prototipo.Curso.MVC.Dominio.Modelos.Funcionario", "Funcionario")
                        .WithMany("ItemLocacoes")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prototipo.Curso.MVC.Dominio.Modelos.Locacao", "Locacao")
                        .WithMany("ItemLocacoes")
                        .HasForeignKey("LocacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Filme");

                    b.Navigation("Funcionario");

                    b.Navigation("Locacao");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Cargo", b =>
                {
                    b.Navigation("Funcionarios");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Cidade", b =>
                {
                    b.Navigation("EnderecoCliente");

                    b.Navigation("EnderecoFuncionario");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Cliente", b =>
                {
                    b.Navigation("Endereco")
                        .IsRequired();

                    b.Navigation("ItemLocacoes");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Diretor", b =>
                {
                    b.Navigation("Filmes");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Estado", b =>
                {
                    b.Navigation("Cidades");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Filme", b =>
                {
                    b.Navigation("ItemLocacoes");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Funcionario", b =>
                {
                    b.Navigation("EnderecoFuncionario")
                        .IsRequired();

                    b.Navigation("ItemLocacoes");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Genero", b =>
                {
                    b.Navigation("Filmes");
                });

            modelBuilder.Entity("Prototipo.Curso.MVC.Dominio.Modelos.Locacao", b =>
                {
                    b.Navigation("ItemLocacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
