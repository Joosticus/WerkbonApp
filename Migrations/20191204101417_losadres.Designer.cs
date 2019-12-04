﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WerkbonAppTest3.Data;

namespace WerkbonAppTest3.Migrations
{
    [DbContext(typeof(WerkbonAppTest3Context))]
    [Migration("20191204101417_losadres")]
    partial class losadres
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WerkbonAppTest3.Models.Klant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contactpersoon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RekeningID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RekeningID");

                    b.ToTable("Klant");
                });

            modelBuilder.Entity("WerkbonAppTest3.Models.Laadadres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Etage")
                        .HasColumnType("int");

                    b.Property<string>("Plaats")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Laadadres");
                });

            modelBuilder.Entity("WerkbonAppTest3.Models.Losadres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Etage")
                        .HasColumnType("int");

                    b.Property<string>("Plaats")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Losadres");
                });

            modelBuilder.Entity("WerkbonAppTest3.Models.Medewerker", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Medewerker");
                });

            modelBuilder.Entity("WerkbonAppTest3.Models.Ongeluk", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Besproken")
                        .HasColumnType("bit");

                    b.Property<int>("KlantID")
                        .HasColumnType("int");

                    b.Property<string>("Kostenplaats")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Schade")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("KlantID");

                    b.ToTable("Ongeluk");
                });

            modelBuilder.Entity("WerkbonAppTest3.Models.Rekening", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Bedrag")
                        .HasColumnType("int");

                    b.Property<string>("Betaalmethode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Rekening");
                });

            modelBuilder.Entity("WerkbonAppTest3.Models.UitvoeringsData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Aankomst_Tijd")
                        .HasColumnType("datetime2");

                    b.Property<int>("Aantal_Laden")
                        .HasColumnType("int");

                    b.Property<int>("Aantal_Lossen")
                        .HasColumnType("int");

                    b.Property<DateTime>("Eind_Laden")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Eind_Lossen")
                        .HasColumnType("datetime2");

                    b.Property<int>("Inpakuren")
                        .HasColumnType("int");

                    b.Property<int>("Laaduren")
                        .HasColumnType("int");

                    b.Property<int>("Losuren")
                        .HasColumnType("int");

                    b.Property<int>("MedewerkerID")
                        .HasColumnType("int");

                    b.Property<int>("Montageuren")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start_Laden")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start_Lossen")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Vertrekuur")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("MedewerkerID");

                    b.ToTable("UitvoeringsData");
                });

            modelBuilder.Entity("WerkbonAppTest3.Models.Verhuiswagen", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Kenteken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Merknaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Verhuiswagen");
                });

            modelBuilder.Entity("WerkbonAppTest3.Models.Klant", b =>
                {
                    b.HasOne("WerkbonAppTest3.Models.Rekening", "Rekening")
                        .WithMany()
                        .HasForeignKey("RekeningID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WerkbonAppTest3.Models.Ongeluk", b =>
                {
                    b.HasOne("WerkbonAppTest3.Models.Klant", "Klant")
                        .WithMany()
                        .HasForeignKey("KlantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WerkbonAppTest3.Models.UitvoeringsData", b =>
                {
                    b.HasOne("WerkbonAppTest3.Models.Medewerker", "Medewerker")
                        .WithMany()
                        .HasForeignKey("MedewerkerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
