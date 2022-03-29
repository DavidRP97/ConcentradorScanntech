using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Concentrador_Scanntech_Repository.Migrations
{
    public partial class SalvarPromocoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeneficioScanntech",
                columns: table => new
                {
                    BeneficioId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficioScanntech", x => x.BeneficioId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CondicaoScanntech",
                columns: table => new
                {
                    CondicaoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicaoScanntech", x => x.CondicaoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BeneficioItemScanntech",
                columns: table => new
                {
                    BeneficioItemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    BeneficioScanntechBeneficioId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficioItemScanntech", x => x.BeneficioItemId);
                    table.ForeignKey(
                        name: "FK_BeneficioItemScanntech_BeneficioScanntech_BeneficioScanntech~",
                        column: x => x.BeneficioScanntechBeneficioId,
                        principalTable: "BeneficioScanntech",
                        principalColumn: "BeneficioId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CondicaoItemScanntech",
                columns: table => new
                {
                    CondicaoItemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CondicaoScanntechCondicaoId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicaoItemScanntech", x => x.CondicaoItemId);
                    table.ForeignKey(
                        name: "FK_CondicaoItemScanntech_CondicaoScanntech_CondicaoScanntechCon~",
                        column: x => x.CondicaoScanntechCondicaoId,
                        principalTable: "CondicaoScanntech",
                        principalColumn: "CondicaoId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalhesPromocaoScanntech",
                columns: table => new
                {
                    DetalhePromocaoScanntechId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BeneficioScanntechId = table.Column<long>(type: "bigint", nullable: true),
                    CondicaoScanntechId = table.Column<long>(type: "bigint", nullable: true),
                    PrecoValorFixo = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    Desconto = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    QuantidadeItensLevaEPaga = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalhesPromocaoScanntech", x => x.DetalhePromocaoScanntechId);
                    table.ForeignKey(
                        name: "FK_DetalhesPromocaoScanntech_BeneficioScanntech_BeneficioScannt~",
                        column: x => x.BeneficioScanntechId,
                        principalTable: "BeneficioScanntech",
                        principalColumn: "BeneficioId");
                    table.ForeignKey(
                        name: "FK_DetalhesPromocaoScanntech_CondicaoScanntech_CondicaoScanntec~",
                        column: x => x.CondicaoScanntechId,
                        principalTable: "CondicaoScanntech",
                        principalColumn: "CondicaoId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BeneficioArtigoScanntech",
                columns: table => new
                {
                    ArtigoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApiId = table.Column<long>(type: "bigint", nullable: false),
                    QuantidadeItensAtivarPromocao = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodigoDeBarras = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BeneficioItemScanntechBeneficioItemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficioArtigoScanntech", x => x.ArtigoId);
                    table.ForeignKey(
                        name: "FK_BeneficioArtigoScanntech_BeneficioItemScanntech_BeneficioIte~",
                        column: x => x.BeneficioItemScanntechBeneficioItemId,
                        principalTable: "BeneficioItemScanntech",
                        principalColumn: "BeneficioItemId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CondicaoArtigoScanntech",
                columns: table => new
                {
                    ArtigoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApiId = table.Column<long>(type: "bigint", nullable: false),
                    QuantidadeItensAtivarPromocao = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodigoDeBarras = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CondicaoItemScanntechCondicaoItemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicaoArtigoScanntech", x => x.ArtigoId);
                    table.ForeignKey(
                        name: "FK_CondicaoArtigoScanntech_CondicaoItemScanntech_CondicaoItemSc~",
                        column: x => x.CondicaoItemScanntechCondicaoItemId,
                        principalTable: "CondicaoItemScanntech",
                        principalColumn: "CondicaoItemId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PromocoesScanntech",
                columns: table => new
                {
                    PromocaoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApiId = table.Column<long>(type: "bigint", nullable: false),
                    LimiteDePromocoesPorTicket = table.Column<int>(type: "int", nullable: true),
                    CargaPdv = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoPromocao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VigenciaDe = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    VigenciaAte = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataEnvioPdv = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DetalhePromocaoScanntechId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromocoesScanntech", x => x.PromocaoId);
                    table.ForeignKey(
                        name: "FK_PromocoesScanntech_DetalhesPromocaoScanntech_DetalhePromocao~",
                        column: x => x.DetalhePromocaoScanntechId,
                        principalTable: "DetalhesPromocaoScanntech",
                        principalColumn: "DetalhePromocaoScanntechId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficioArtigoScanntech_BeneficioItemScanntechBeneficioItem~",
                table: "BeneficioArtigoScanntech",
                column: "BeneficioItemScanntechBeneficioItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficioItemScanntech_BeneficioScanntechBeneficioId",
                table: "BeneficioItemScanntech",
                column: "BeneficioScanntechBeneficioId");

            migrationBuilder.CreateIndex(
                name: "IX_CondicaoArtigoScanntech_CondicaoItemScanntechCondicaoItemId",
                table: "CondicaoArtigoScanntech",
                column: "CondicaoItemScanntechCondicaoItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CondicaoItemScanntech_CondicaoScanntechCondicaoId",
                table: "CondicaoItemScanntech",
                column: "CondicaoScanntechCondicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalhesPromocaoScanntech_BeneficioScanntechId",
                table: "DetalhesPromocaoScanntech",
                column: "BeneficioScanntechId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalhesPromocaoScanntech_CondicaoScanntechId",
                table: "DetalhesPromocaoScanntech",
                column: "CondicaoScanntechId");

            migrationBuilder.CreateIndex(
                name: "IX_PromocoesScanntech_DetalhePromocaoScanntechId",
                table: "PromocoesScanntech",
                column: "DetalhePromocaoScanntechId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeneficioArtigoScanntech");

            migrationBuilder.DropTable(
                name: "CondicaoArtigoScanntech");

            migrationBuilder.DropTable(
                name: "PromocoesScanntech");

            migrationBuilder.DropTable(
                name: "BeneficioItemScanntech");

            migrationBuilder.DropTable(
                name: "CondicaoItemScanntech");

            migrationBuilder.DropTable(
                name: "DetalhesPromocaoScanntech");

            migrationBuilder.DropTable(
                name: "BeneficioScanntech");

            migrationBuilder.DropTable(
                name: "CondicaoScanntech");
        }
    }
}
