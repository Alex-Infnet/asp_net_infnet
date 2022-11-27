using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNetMvcEF.Migrations
{
    /// <inheritdoc />
    public partial class AddFornecedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identificator = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_produtos_FornecedorId",
                table: "produtos",
                column: "FornecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_Fornecedor_FornecedorId",
                table: "produtos",
                column: "FornecedorId",
                principalTable: "Fornecedor",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produtos_Fornecedor_FornecedorId",
                table: "produtos");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropIndex(
                name: "IX_produtos_FornecedorId",
                table: "produtos");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "produtos");
        }
    }
}
