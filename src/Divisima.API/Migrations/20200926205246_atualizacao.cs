using Microsoft.EntityFrameworkCore.Migrations;

namespace divisima.Migrations
{
    public partial class atualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Produtos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Produtos",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
