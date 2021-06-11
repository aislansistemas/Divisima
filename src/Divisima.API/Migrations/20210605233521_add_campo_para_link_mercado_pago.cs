using Microsoft.EntityFrameworkCore.Migrations;

namespace Divisima.API.Migrations
{
    public partial class add_campo_para_link_mercado_pago : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkMercadoPago",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkMercadoPago",
                table: "Produtos");
        }
    }
}
