using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaAPI.Migrations
{
    public partial class Att5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SalaId",
                table: "Sala",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProgramacaoId",
                table: "Programacao",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IngressoId",
                table: "Ingressos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FilmeId",
                table: "Filmes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BarId",
                table: "Bar",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Sala",
                newName: "SalaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Programacao",
                newName: "ProgramacaoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ingressos",
                newName: "IngressoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Filmes",
                newName: "FilmeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bar",
                newName: "BarId");
        }
    }
}
