using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace divisima.Migrations
{
    public partial class adiciona_entidade_para_fotos_de_produtos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Produtos");

            migrationBuilder.CreateTable(
                name: "FotoProduto",
                columns: table => new
                {
                    FotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Foto = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IsFotoPrincipal = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotoProduto", x => x.FotoId);
                    table.ForeignKey(
                        name: "FK_FotoProduto_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FotoProduto_ProdutoId",
                table: "FotoProduto",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FotoProduto");

            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "Produtos",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
