using Microsoft.EntityFrameworkCore.Migrations;

namespace divisima.Migrations
{
    public partial class adiciona_propriedade_ativo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ativo",
                table: "Categorias",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Categorias");
        }
    }
}
