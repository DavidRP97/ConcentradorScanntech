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
    [Migration("20220325190958_definicoes")]
    partial class definicoes
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

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Definicoes.URL", b =>
                {
                    b.HasOne("Concentrador_Scanntech_Entities.Model.Definicoes.DefinicoesScanntech", null)
                        .WithMany("uRLs")
                        .HasForeignKey("DefinicoesScanntechId");
                });

            modelBuilder.Entity("Concentrador_Scanntech_Entities.Model.Definicoes.DefinicoesScanntech", b =>
                {
                    b.Navigation("uRLs");
                });
#pragma warning restore 612, 618
        }
    }
}