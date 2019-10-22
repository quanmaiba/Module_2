﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonApp.Data;

namespace PokemonApp.Data.Migrations
{
    [DbContext(typeof(PokemonContext))]
    [Migration("20191001043237_addPokemonBattle")]
    partial class addPokemonBattle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PokemonApp.Domain.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("PokemonApp.Domain.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PokemonId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("PokemonId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("PokemonApp.Domain.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("PokemonApp.Domain.PokemonBattle", b =>
                {
                    b.Property<int>("BattleId");

                    b.Property<int>("PokemonId");

                    b.HasKey("BattleId", "PokemonId");

                    b.HasIndex("PokemonId");

                    b.ToTable("PokemonBattle");
                });

            modelBuilder.Entity("PokemonApp.Domain.Note", b =>
                {
                    b.HasOne("PokemonApp.Domain.Pokemon", "Pokemon")
                        .WithMany("Notes")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PokemonApp.Domain.PokemonBattle", b =>
                {
                    b.HasOne("PokemonApp.Domain.Battle", "Battle")
                        .WithMany()
                        .HasForeignKey("BattleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PokemonApp.Domain.Pokemon", "Pokemon")
                        .WithMany()
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}