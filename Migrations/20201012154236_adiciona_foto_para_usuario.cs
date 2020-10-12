using Microsoft.EntityFrameworkCore.Migrations;

namespace divisima.Migrations
{
    public partial class adiciona_foto_para_usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "AspNetUsers");
        }
    }
}
