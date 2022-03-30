using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Concentrador_Scanntech_Repository.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeneficioScanntech",
                columns: table => new
                {
                    BeneficioId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficioScanntech", x => x.BeneficioId);
                });

            migrationBuilder.CreateTable(
                name: "CondicaoScanntech",
                columns: table => new
                {
                    CondicaoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicaoScanntech", x => x.CondicaoId);
                });

            migrationBuilder.CreateTable(
                name: "DefinicoesScanntech",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataDeIntegração = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    HorarioDeEnvioFechamento = table.Column<string>(type: "text", nullable: false),
                    Usuario = table.Column<string>(type: "text", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false),
                    SincronizacaoPromocoes = table.Column<int>(type: "integer", nullable: false),
                    SincronizacaoVendas = table.Column<int>(type: "integer", nullable: false),
                    SincronizacaoManual = table.Column<int>(type: "integer", nullable: false),
                    IdCompanhia = table.Column<int>(type: "integer", nullable: false),
                    IdLocal = table.Column<int>(type: "integer", nullable: false),
                    QuantidadeDeEnviosParaScanntech = table.Column<int>(type: "integer", nullable: false),
                    EstadoDaPromocao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefinicoesScanntech", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusDoBanco",
                columns: table => new
                {
                    StatusId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StatusDoBanco = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusDoBanco", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "BeneficioItemScanntech",
                columns: table => new
                {
                    BeneficioItemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    BeneficioScanntechBeneficioId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficioItemScanntech", x => x.BeneficioItemId);
                    table.ForeignKey(
                        name: "FK_BeneficioItemScanntech_BeneficioScanntech_BeneficioScanntec~",
                        column: x => x.BeneficioScanntechBeneficioId,
                        principalTable: "BeneficioScanntech",
                        principalColumn: "BeneficioId");
                });

            migrationBuilder.CreateTable(
                name: "CondicaoItemScanntech",
                columns: table => new
                {
                    CondicaoItemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    CondicaoScanntechCondicaoId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicaoItemScanntech", x => x.CondicaoItemId);
                    table.ForeignKey(
                        name: "FK_CondicaoItemScanntech_CondicaoScanntech_CondicaoScanntechCo~",
                        column: x => x.CondicaoScanntechCondicaoId,
                        principalTable: "CondicaoScanntech",
                        principalColumn: "CondicaoId");
                });

            migrationBuilder.CreateTable(
                name: "DetalhesPromocaoScanntech",
                columns: table => new
                {
                    DetalhePromocaoScanntechId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BeneficioScanntechId = table.Column<long>(type: "bigint", nullable: true),
                    CondicaoScanntechId = table.Column<long>(type: "bigint", nullable: true),
                    PrecoValorFixo = table.Column<decimal>(type: "numeric", nullable: true),
                    Desconto = table.Column<decimal>(type: "numeric", nullable: true),
                    QuantidadeItensLevaEPaga = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalhesPromocaoScanntech", x => x.DetalhePromocaoScanntechId);
                    table.ForeignKey(
                        name: "FK_DetalhesPromocaoScanntech_BeneficioScanntech_BeneficioScann~",
                        column: x => x.BeneficioScanntechId,
                        principalTable: "BeneficioScanntech",
                        principalColumn: "BeneficioId");
                    table.ForeignKey(
                        name: "FK_DetalhesPromocaoScanntech_CondicaoScanntech_CondicaoScannte~",
                        column: x => x.CondicaoScanntechId,
                        principalTable: "CondicaoScanntech",
                        principalColumn: "CondicaoId");
                });

            migrationBuilder.CreateTable(
                name: "URLs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UrlConnection = table.Column<string>(type: "text", nullable: false),
                    DefinicoesScanntechId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_URLs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_URLs_DefinicoesScanntech_DefinicoesScanntechId",
                        column: x => x.DefinicoesScanntechId,
                        principalTable: "DefinicoesScanntech",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BeneficioArtigoScanntech",
                columns: table => new
                {
                    ArtigoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    CodigoDeBarras = table.Column<string>(type: "text", nullable: false),
                    BeneficioItemScanntechBeneficioItemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficioArtigoScanntech", x => x.ArtigoId);
                    table.ForeignKey(
                        name: "FK_BeneficioArtigoScanntech_BeneficioItemScanntech_BeneficioIt~",
                        column: x => x.BeneficioItemScanntechBeneficioItemId,
                        principalTable: "BeneficioItemScanntech",
                        principalColumn: "BeneficioItemId");
                });

            migrationBuilder.CreateTable(
                name: "CondicaoArtigoScanntech",
                columns: table => new
                {
                    ArtigoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    CodigoDeBarras = table.Column<string>(type: "text", nullable: false),
                    CondicaoItemScanntechCondicaoItemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicaoArtigoScanntech", x => x.ArtigoId);
                    table.ForeignKey(
                        name: "FK_CondicaoArtigoScanntech_CondicaoItemScanntech_CondicaoItemS~",
                        column: x => x.CondicaoItemScanntechCondicaoItemId,
                        principalTable: "CondicaoItemScanntech",
                        principalColumn: "CondicaoItemId");
                });

            migrationBuilder.CreateTable(
                name: "PromocoesScanntech",
                columns: table => new
                {
                    PromocaoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApiId = table.Column<long>(type: "bigint", nullable: false),
                    LimiteDePromocoesPorTicket = table.Column<int>(type: "integer", nullable: true),
                    CargaPdv = table.Column<bool>(type: "boolean", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: false),
                    TipoPromocao = table.Column<string>(type: "text", nullable: false),
                    VigenciaDe = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    VigenciaAte = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DataEnvioPdv = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DetalhePromocaoScanntechId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromocoesScanntech", x => x.PromocaoId);
                    table.ForeignKey(
                        name: "FK_PromocoesScanntech_DetalhesPromocaoScanntech_DetalhePromoca~",
                        column: x => x.DetalhePromocaoScanntechId,
                        principalTable: "DetalhesPromocaoScanntech",
                        principalColumn: "DetalhePromocaoScanntechId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "StatusDoBanco",
                columns: new[] { "StatusId", "StatusDoBanco" },
                values: new object[] { 1L, true });

            migrationBuilder.CreateIndex(
                name: "IX_BeneficioArtigoScanntech_BeneficioItemScanntechBeneficioIte~",
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

            migrationBuilder.CreateIndex(
                name: "IX_URLs_DefinicoesScanntechId",
                table: "URLs",
                column: "DefinicoesScanntechId");
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
                name: "StatusDoBanco");

            migrationBuilder.DropTable(
                name: "URLs");

            migrationBuilder.DropTable(
                name: "BeneficioItemScanntech");

            migrationBuilder.DropTable(
                name: "CondicaoItemScanntech");

            migrationBuilder.DropTable(
                name: "DetalhesPromocaoScanntech");

            migrationBuilder.DropTable(
                name: "DefinicoesScanntech");

            migrationBuilder.DropTable(
                name: "BeneficioScanntech");

            migrationBuilder.DropTable(
                name: "CondicaoScanntech");
        }
    }
}
