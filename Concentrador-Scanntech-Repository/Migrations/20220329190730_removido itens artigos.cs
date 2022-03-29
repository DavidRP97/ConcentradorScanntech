using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Concentrador_Scanntech_Repository.Migrations
{
    public partial class removidoitensartigos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApiId",
                table: "CondicaoArtigoScanntech");

            migrationBuilder.DropColumn(
                name: "QuantidadeItensAtivarPromocao",
                table: "CondicaoArtigoScanntech");

            migrationBuilder.DropColumn(
                name: "ApiId",
                table: "BeneficioArtigoScanntech");

            migrationBuilder.DropColumn(
                name: "QuantidadeItensAtivarPromocao",
                table: "BeneficioArtigoScanntech");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ApiId",
                table: "CondicaoArtigoScanntech",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeItensAtivarPromocao",
                table: "CondicaoArtigoScanntech",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "ApiId",
                table: "BeneficioArtigoScanntech",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeItensAtivarPromocao",
                table: "BeneficioArtigoScanntech",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
