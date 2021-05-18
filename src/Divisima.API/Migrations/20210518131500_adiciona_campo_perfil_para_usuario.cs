using Microsoft.EntityFrameworkCore.Migrations;

namespace Divisima.API.Migrations
{
    public partial class adiciona_campo_perfil_para_usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PerfilUsuario",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PerfilUsuario",
                table: "AspNetUsers");
        }
    }
}
