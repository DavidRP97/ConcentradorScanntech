using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Concentrador_Scanntech_Repository.Migrations
{
    public partial class definicoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "DefinicoesScanntech");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "DefinicoesScanntech");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "DefinicoesScanntech",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "TempoVendas",
                table: "DefinicoesScanntech",
                newName: "SincronizacaoVendas");

            migrationBuilder.RenameColumn(
                name: "TempoSincronizacao",
                table: "DefinicoesScanntech",
                newName: "SincronizacaoPromocoes");

            migrationBuilder.RenameColumn(
                name: "TempoPromocoes",
                table: "DefinicoesScanntech",
                newName: "SincronizacaoManual");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "DefinicoesScanntech",
                newName: "IdLocal");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "DefinicoesScanntech",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "LocalId",
                table: "DefinicoesScanntech",
                newName: "IdCompanhia");

            migrationBuilder.RenameColumn(
                name: "DiasParaExclusaoDeLog",
                table: "DefinicoesScanntech",
                newName: "EstadoDaPromocao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "DefinicoesScanntech",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "SincronizacaoVendas",
                table: "DefinicoesScanntech",
                newName: "TempoVendas");

            migrationBuilder.RenameColumn(
                name: "SincronizacaoPromocoes",
                table: "DefinicoesScanntech",
                newName: "TempoSincronizacao");

            migrationBuilder.RenameColumn(
                name: "SincronizacaoManual",
                table: "DefinicoesScanntech",
                newName: "TempoPromocoes");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "DefinicoesScanntech",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "IdLocal",
                table: "DefinicoesScanntech",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "IdCompanhia",
                table: "DefinicoesScanntech",
                newName: "LocalId");

            migrationBuilder.RenameColumn(
                name: "EstadoDaPromocao",
                table: "DefinicoesScanntech",
                newName: "DiasParaExclusaoDeLog");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "DefinicoesScanntech",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "DefinicoesScanntech",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
