using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prototipo.Curso.MVC.Dados.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CARGO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    Administrador = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CARGO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_CLIENTE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(35)", nullable: false),
                    SobreNome = table.Column<string>(type: "varchar(60)", nullable: false),
                    Email = table.Column<string>(type: "varchar(70)", nullable: false),
                    Celular = table.Column<string>(type: "varchar(20)", nullable: false),
                    TelFixo = table.Column<string>(type: "varchar(20)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CLIENTE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_DIRETOR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DIRETOR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_ESTADO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEstado = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ESTADO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_GENERO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeGenero = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_GENERO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_FUNCIONARIO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salario = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    DataAdmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDesligamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    CargoId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(35)", nullable: false),
                    SobreNome = table.Column<string>(type: "varchar(60)", nullable: false),
                    Email = table.Column<string>(type: "varchar(70)", nullable: false),
                    Celular = table.Column<string>(type: "varchar(20)", nullable: false),
                    TelFixo = table.Column<string>(type: "varchar(20)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FUNCIONARIO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_FUNCIONARIO_TB_CARGO_CargoId",
                        column: x => x.CargoId,
                        principalTable: "TB_CARGO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_CIDADE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CIDADE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_CIDADE_TB_ESTADO_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "TB_ESTADO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_FILME",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TituloFilme = table.Column<string>(type: "varchar(70)", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    ValorDiaria = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DiretorId = table.Column<int>(type: "int", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FILME", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_FILME_TB_DIRETOR_DiretorId",
                        column: x => x.DiretorId,
                        principalTable: "TB_DIRETOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_FILME_TB_GENERO_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "TB_GENERO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ENDERECO_CLIENTE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    CidadeId = table.Column<int>(type: "int", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(70)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50)", nullable: false),
                    CEP = table.Column<string>(type: "varchar(20)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ENDERECO_CLIENTE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_ENDERECO_CLIENTE_TB_CIDADE_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "TB_CIDADE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_ENDERECO_CLIENTE_TB_CLIENTE_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "TB_CLIENTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ENDERECO_FUNCIONARIO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    CidadeId = table.Column<int>(type: "int", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(70)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50)", nullable: false),
                    CEP = table.Column<string>(type: "varchar(20)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ENDERECO_FUNCIONARIO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_ENDERECO_FUNCIONARIO_TB_CIDADE_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "TB_CIDADE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_ENDERECO_FUNCIONARIO_TB_FUNCIONARIO_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "TB_FUNCIONARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_ITEM_LOCACAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diarias = table.Column<int>(type: "int", nullable: false),
                    ValorDiaria = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    FilmeId = table.Column<int>(type: "int", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ITEM_LOCACAO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_ITEM_LOCACAO_TB_CLIENTE_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "TB_CLIENTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_ITEM_LOCACAO_TB_FILME_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "TB_FILME",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_ITEM_LOCACAO_TB_FUNCIONARIO_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "TB_FUNCIONARIO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_LOCACAO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorTotal = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    DataLocacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MultaAtraso = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ItemLocacaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_LOCACAO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_LOCACAO_TB_ITEM_LOCACAO_ItemLocacaoId",
                        column: x => x.ItemLocacaoId,
                        principalTable: "TB_ITEM_LOCACAO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_CIDADE_EstadoId",
                table: "TB_CIDADE",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ENDERECO_CLIENTE_CidadeId",
                table: "TB_ENDERECO_CLIENTE",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ENDERECO_CLIENTE_ClienteId",
                table: "TB_ENDERECO_CLIENTE",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_ENDERECO_FUNCIONARIO_CidadeId",
                table: "TB_ENDERECO_FUNCIONARIO",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ENDERECO_FUNCIONARIO_FuncionarioId",
                table: "TB_ENDERECO_FUNCIONARIO",
                column: "FuncionarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_FILME_DiretorId",
                table: "TB_FILME",
                column: "DiretorId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_FILME_GeneroId",
                table: "TB_FILME",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_FUNCIONARIO_CargoId",
                table: "TB_FUNCIONARIO",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ITEM_LOCACAO_ClienteId",
                table: "TB_ITEM_LOCACAO",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ITEM_LOCACAO_FilmeId",
                table: "TB_ITEM_LOCACAO",
                column: "FilmeId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ITEM_LOCACAO_FuncionarioId",
                table: "TB_ITEM_LOCACAO",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_LOCACAO_ItemLocacaoId",
                table: "TB_LOCACAO",
                column: "ItemLocacaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ENDERECO_CLIENTE");

            migrationBuilder.DropTable(
                name: "TB_ENDERECO_FUNCIONARIO");

            migrationBuilder.DropTable(
                name: "TB_LOCACAO");

            migrationBuilder.DropTable(
                name: "TB_CIDADE");

            migrationBuilder.DropTable(
                name: "TB_ITEM_LOCACAO");

            migrationBuilder.DropTable(
                name: "TB_ESTADO");

            migrationBuilder.DropTable(
                name: "TB_CLIENTE");

            migrationBuilder.DropTable(
                name: "TB_FILME");

            migrationBuilder.DropTable(
                name: "TB_FUNCIONARIO");

            migrationBuilder.DropTable(
                name: "TB_DIRETOR");

            migrationBuilder.DropTable(
                name: "TB_GENERO");

            migrationBuilder.DropTable(
                name: "TB_CARGO");
        }
    }
}
