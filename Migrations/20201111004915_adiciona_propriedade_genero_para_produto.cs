using Microsoft.EntityFrameworkCore.Migrations;

namespace divisima.Migrations
{
    public partial class adiciona_propriedade_genero_para_produto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Genero",
                table: "Produtos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Produtos");
        }
    }
}
