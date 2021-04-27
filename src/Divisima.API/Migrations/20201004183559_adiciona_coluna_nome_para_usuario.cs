using Microsoft.EntityFrameworkCore.Migrations;

namespace divisima.Migrations
{
    public partial class adiciona_coluna_nome_para_usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "AspNetUsers");
        }
    }
}
