using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppTarefa.Migrations
{
    public partial class BancoV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<DateTime>(nullable: true),
                    HorarioInicial = table.Column<TimeSpan>(nullable: false),
                    HorarioFinal = table.Column<TimeSpan>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Nota = table.Column<string>(nullable: true),
                    Finalizada = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");
        }
    }
}
