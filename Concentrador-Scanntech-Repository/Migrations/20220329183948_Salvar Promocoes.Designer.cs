﻿// <auto-generated />
using System;
using Concentrador_Scanntech_Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Concentrador_Scanntech_Repository.Migrations
{
    [DbContext(typeof(MySqlDbContext))]
    [Migration("20220329183948_Salvar Promocoes")]
    partial class SalvarPromocoes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Definicoes.DefinicoesScanntech", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataDeIntegração")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EstadoDaPromocao")
                        .HasColumnType("int");

                    b.Property<string>("HorarioDeEnvioFechamento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdCompanhia")
                        .HasColumnType("int");

                    b.Property<int>("IdLocal")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeDeEnviosParaScanntech")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SincronizacaoManual")
                        .HasColumnType("int");

                    b.Property<int>("SincronizacaoPromocoes")
                        .HasColumnType("int");

                    b.Property<int>("SincronizacaoVendas")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DefinicoesScanntech");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Definicoes.Status", b =>
                {
                    b.Property<long>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<bool>("StatusDoBanco")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("StatusId");

                    b.ToTable("StatusDoBanco");

                    b.HasData(
                        new
                        {
                            StatusId = 1L,
                            StatusDoBanco = true
                        });
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Definicoes.URL", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("DefinicoesScanntechId")
                        .HasColumnType("bigint");

                    b.Property<string>("UrlConnection")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DefinicoesScanntechId");

                    b.ToTable("URLs");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.BeneficioArtigoScanntech", b =>
                {
                    b.Property<long>("ArtigoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("ApiId")
                        .HasColumnType("bigint");

                    b.Property<long?>("BeneficioItemScanntechBeneficioItemId")
                        .HasColumnType("bigint");

                    b.Property<string>("CodigoDeBarras")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QuantidadeItensAtivarPromocao")
                        .HasColumnType("int");

                    b.HasKey("ArtigoId");

                    b.HasIndex("BeneficioItemScanntechBeneficioItemId");

                    b.ToTable("BeneficioArtigoScanntech");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.BeneficioItemScanntech", b =>
                {
                    b.Property<long>("BeneficioItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("BeneficioScanntechBeneficioId")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("BeneficioItemId");

                    b.HasIndex("BeneficioScanntechBeneficioId");

                    b.ToTable("BeneficioItemScanntech");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.BeneficioScanntech", b =>
                {
                    b.Property<long>("BeneficioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.HasKey("BeneficioId");

                    b.ToTable("BeneficioScanntech");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.CondicaoArtigoScanntech", b =>
                {
                    b.Property<long>("ArtigoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("ApiId")
                        .HasColumnType("bigint");

                    b.Property<string>("CodigoDeBarras")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long?>("CondicaoItemScanntechCondicaoItemId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("QuantidadeItensAtivarPromocao")
                        .HasColumnType("int");

                    b.HasKey("ArtigoId");

                    b.HasIndex("CondicaoItemScanntechCondicaoItemId");

                    b.ToTable("CondicaoArtigoScanntech");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.CondicaoItemScanntech", b =>
                {
                    b.Property<long>("CondicaoItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("CondicaoScanntechCondicaoId")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("CondicaoItemId");

                    b.HasIndex("CondicaoScanntechCondicaoId");

                    b.ToTable("CondicaoItemScanntech");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.CondicaoScanntech", b =>
                {
                    b.Property<long>("CondicaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.HasKey("CondicaoId");

                    b.ToTable("CondicaoScanntech");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.DetalhesPromocaoScanntech", b =>
                {
                    b.Property<long>("DetalhePromocaoScanntechId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("BeneficioScanntechId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CondicaoScanntechId")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("Desconto")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal?>("PrecoValorFixo")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("QuantidadeItensLevaEPaga")
                        .HasColumnType("int");

                    b.HasKey("DetalhePromocaoScanntechId");

                    b.HasIndex("BeneficioScanntechId");

                    b.HasIndex("CondicaoScanntechId");

                    b.ToTable("DetalhesPromocaoScanntech");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.PromocaoScanntech", b =>
                {
                    b.Property<long>("PromocaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("ApiId")
                        .HasColumnType("bigint");

                    b.Property<bool>("CargaPdv")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataEnvioPdv")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("DetalhePromocaoScanntechId")
                        .HasColumnType("bigint");

                    b.Property<int?>("LimiteDePromocoesPorTicket")
                        .HasColumnType("int");

                    b.Property<string>("TipoPromocao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("VigenciaAte")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("VigenciaDe")
                        .HasColumnType("datetime(6)");

                    b.HasKey("PromocaoId");

                    b.HasIndex("DetalhePromocaoScanntechId");

                    b.ToTable("PromocoesScanntech");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Definicoes.URL", b =>
                {
                    b.HasOne("Concentrador_Scanntech_Entities.Model.Definicoes.DefinicoesScanntech", null)
                        .WithMany("uRLs")
                        .HasForeignKey("DefinicoesScanntechId");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.BeneficioArtigoScanntech", b =>
                {
                    b.HasOne("Concentrador_Scanntech_Entities.Model.Promocoes.BeneficioItemScanntech", null)
                        .WithMany("ArtigosBeneficios")
                        .HasForeignKey("BeneficioItemScanntechBeneficioItemId");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.BeneficioItemScanntech", b =>
                {
                    b.HasOne("Concentrador_Scanntech_Entities.Model.Promocoes.BeneficioScanntech", null)
                        .WithMany("BeneficioItens")
                        .HasForeignKey("BeneficioScanntechBeneficioId");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.CondicaoArtigoScanntech", b =>
                {
                    b.HasOne("Concentrador_Scanntech_Entities.Model.Promocoes.CondicaoItemScanntech", null)
                        .WithMany("ArtigosCondicoes")
                        .HasForeignKey("CondicaoItemScanntechCondicaoItemId");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.CondicaoItemScanntech", b =>
                {
                    b.HasOne("Concentrador_Scanntech_Entities.Model.Promocoes.CondicaoScanntech", null)
                        .WithMany("CondicoesItens")
                        .HasForeignKey("CondicaoScanntechCondicaoId");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.DetalhesPromocaoScanntech", b =>
                {
                    b.HasOne("Concentrador_Scanntech_Entities.Model.Promocoes.BeneficioScanntech", "BeneficioScanntech")
                        .WithMany()
                        .HasForeignKey("BeneficioScanntechId");

                    b.HasOne("Concentrador_Scanntech_Entities.Model.Promocoes.CondicaoScanntech", "CondicaoScanntech")
                        .WithMany()
                        .HasForeignKey("CondicaoScanntechId");

                    b.Navigation("BeneficioScanntech");

                    b.Navigation("CondicaoScanntech");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.PromocaoScanntech", b =>
                {
                    b.HasOne("Concentrador_Scanntech_Entities.Model.Promocoes.DetalhesPromocaoScanntech", "DetalhePromocaoScanntech")
                        .WithMany()
                        .HasForeignKey("DetalhePromocaoScanntechId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DetalhePromocaoScanntech");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Definicoes.DefinicoesScanntech", b =>
                {
                    b.Navigation("uRLs");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.BeneficioItemScanntech", b =>
                {
                    b.Navigation("ArtigosBeneficios");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.BeneficioScanntech", b =>
                {
                    b.Navigation("BeneficioItens");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.CondicaoItemScanntech", b =>
                {
                    b.Navigation("ArtigosCondicoes");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Promocoes.CondicaoScanntech", b =>
                {
                    b.Navigation("CondicoesItens");
                });
#pragma warning restore 612, 618
        }
    }
}
