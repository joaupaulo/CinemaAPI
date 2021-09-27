using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaAPI.Migrations
{
    public partial class Att : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinema",
                columns: table => new
                {
                    CinemaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CinemaNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardapioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinema", x => x.CinemaId);
                });

            migrationBuilder.CreateTable(
                name: "Bar",
                columns: table => new
                {
                    CardapioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bebida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Combo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sobremesa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CinemaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bar", x => x.CardapioId);
                    table.ForeignKey(
                        name: "FK_Bar_Cinema_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinema",
                        principalColumn: "CinemaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Atores = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duracao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sinopse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avaliacao = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.FilmeId);
                    table.ForeignKey(
                        name: "FK_Filmes_Cinema_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinema",
                        principalColumn: "CinemaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingressos",
                columns: table => new
                {
                    IngressoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorIntegral = table.Column<int>(type: "int", nullable: false),
                    ValorMeia = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingressos", x => x.IngressoId);
                    table.ForeignKey(
                        name: "FK_Ingressos_Cinema_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinema",
                        principalColumn: "CinemaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Programacao",
                columns: table => new
                {
                    ProgramacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmeHoje = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmeSemana = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programacao", x => x.ProgramacaoId);
                    table.ForeignKey(
                        name: "FK_Programacao_Cinema_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinema",
                        principalColumn: "CinemaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sala",
                columns: table => new
                {
                    SalaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroPoltrona = table.Column<int>(type: "int", nullable: false),
                    CinemaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sala", x => x.SalaId);
                    table.ForeignKey(
                        name: "FK_Sala_Cinema_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinema",
                        principalColumn: "CinemaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bar_CinemaId",
                table: "Bar",
                column: "CinemaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_CinemaId",
                table: "Filmes",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingressos_CinemaId",
                table: "Ingressos",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Programacao_CinemaId",
                table: "Programacao",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Sala_CinemaId",
                table: "Sala",
                column: "CinemaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bar");

            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Ingressos");

            migrationBuilder.DropTable(
                name: "Programacao");

            migrationBuilder.DropTable(
                name: "Sala");

            migrationBuilder.DropTable(
                name: "Cinema");
        }
    }
}
