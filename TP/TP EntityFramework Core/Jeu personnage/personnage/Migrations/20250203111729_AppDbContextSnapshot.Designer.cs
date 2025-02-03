﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using personnage.Data;

#nullable disable

namespace personnage.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250203111729_AppDbContextSnapshot")]
    partial class AppDbContextSnapshot
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("personnage.Models.Personnage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Armure")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<int>("Degats")
                        .HasColumnType("int");

                    b.Property<int>("Kills")
                        .HasColumnType("int");

                    b.Property<int>("PointsDeVie")
                        .HasColumnType("int");

                    b.Property<string>("Pseudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Personnages");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Armure = 100,
                            DateCreation = new DateTime(2025, 2, 3, 12, 17, 29, 331, DateTimeKind.Local).AddTicks(3779),
                            Degats = 10,
                            Kills = 0,
                            PointsDeVie = 100,
                            Pseudo = "Fuziio"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
