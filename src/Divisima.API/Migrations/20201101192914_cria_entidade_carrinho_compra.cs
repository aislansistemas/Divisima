using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace divisima.Migrations
{
    public partial class cria_entidade_carrinho_compra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarrinhoCompraItems",
                columns: table => new
                {
                    CarrinhoCompraId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoCompraItems", x => x.CarrinhoCompraId);
                    table.ForeignKey(
                        name: "FK_CarrinhoCompraItems_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarrinhoCompraItems_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompraItems_ProdutoId",
                table: "CarrinhoCompraItems",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompraItems_UsuarioId",
                table: "CarrinhoCompraItems",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoCompraItems");
        }
    }
}
