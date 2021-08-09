﻿// <auto-generated />
using System;
using GameFantasyAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameFantasy.Migrations
{
    [DbContext(typeof(CampeonatoContexto))]
    partial class CampeonatoContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameFantasyAPI.Model.Campeonato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Campeao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Terceiro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Campeonatos");
                });

            modelBuilder.Entity("GameFantasyAPI.Model.Partida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CampeonatoId")
                        .HasColumnType("int");

                    b.Property<string>("Placar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Times")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CampeonatoId");

                    b.ToTable("Partidas");
                });

            modelBuilder.Entity("GameFantasyAPI.Model.Time", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pontos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Times");
                });

            modelBuilder.Entity("GameFantasyAPI.Model.Partida", b =>
                {
                    b.HasOne("GameFantasyAPI.Model.Campeonato", null)
                        .WithMany("Partidas")
                        .HasForeignKey("CampeonatoId");
                });
#pragma warning restore 612, 618
        }
    }
}
