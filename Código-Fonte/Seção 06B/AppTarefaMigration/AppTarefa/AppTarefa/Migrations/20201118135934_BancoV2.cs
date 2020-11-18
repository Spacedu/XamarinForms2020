using Microsoft.EntityFrameworkCore.Migrations;

namespace AppTarefa.Migrations
{
    public partial class BancoV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Prioridade",
                table: "Tarefas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prioridade",
                table: "Tarefas");
        }
    }
}
