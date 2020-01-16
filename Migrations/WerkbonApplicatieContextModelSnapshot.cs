﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WerkbonApplicatie.Data;

namespace WerkbonApplicatie.Migrations
{
    [DbContext(typeof(WerkbonApplicatieContext))]
    partial class WerkbonApplicatieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WerkbonApplicatie.Models.Personeel", b =>
                {
                    b.Property<int>("PersoneelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Personeel_Achternaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesoneel_VoorNaam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersoneelID");

                    b.ToTable("Personeel");
                });

            modelBuilder.Entity("WerkbonApplicatie.Models.Werkbon", b =>
                {
                    b.Property<int>("WerkbonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Aankomsttijd_Zaak")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Aansluiten_Witgoed")
                        .HasColumnType("bit");

                    b.Property<int>("Aantal_Geladen")
                        .HasColumnType("int");

                    b.Property<int>("Aantal_Gelost")
                        .HasColumnType("int");

                    b.Property<DateTime>("Aanvangstijd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Achtergelaten_Materiaal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Achternaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Afhalen_Lamp")
                        .HasColumnType("bit");

                    b.Property<bool>("Afsluiten_Witgoed")
                        .HasColumnType("bit");

                    b.Property<bool>("Barrel")
                        .HasColumnType("bit");

                    b.Property<int>("Bedrag")
                        .HasColumnType("int");

                    b.Property<string>("Betaalwijze")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Demontage")
                        .HasColumnType("bit");

                    b.Property<int>("Demontage_Manuren")
                        .HasColumnType("int");

                    b.Property<bool>("Drempelplaat")
                        .HasColumnType("bit");

                    b.Property<bool>("Eenpersoons_Matrashoes")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Eindtijd_Laden")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Eindtijd_Lossen")
                        .HasColumnType("datetime2");

                    b.Property<string>("Extra_Materiaal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Groot_Volume_Bak")
                        .HasColumnType("bit");

                    b.Property<string>("Guid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuidSecond")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Handymankoffers")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSecond")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Inpakken")
                        .HasColumnType("bit");

                    b.Property<int>("Inpakken_Manuren")
                        .HasColumnType("int");

                    b.Property<bool>("Intern_Transport")
                        .HasColumnType("bit");

                    b.Property<string>("Kenteken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Klant_Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KostenPlaats")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LaadAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LaadEtage")
                        .HasColumnType("int");

                    b.Property<string>("LaadPlaats")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Laaduur_Totaal")
                        .HasColumnType("int");

                    b.Property<bool>("Laden")
                        .HasColumnType("bit");

                    b.Property<string>("LosAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LosEtage")
                        .HasColumnType("int");

                    b.Property<string>("LosPlaats")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Lossen")
                        .HasColumnType("bit");

                    b.Property<int>("Losuur_Totaal")
                        .HasColumnType("int");

                    b.Property<string>("Merk_Kraan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Montage")
                        .HasColumnType("bit");

                    b.Property<int>("Montage_Manuren")
                        .HasColumnType("int");

                    b.Property<bool>("Noppenfolie")
                        .HasColumnType("bit");

                    b.Property<bool>("Ophangen_Lamp")
                        .HasColumnType("bit");

                    b.Property<bool>("Rolsteiger")
                        .HasColumnType("bit");

                    b.Property<string>("Schade_Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Schade_Besproken")
                        .HasColumnType("bit");

                    b.Property<bool>("Schade_Veroorzaakt")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Starttijd_Laden")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Starttijd_Lossen")
                        .HasColumnType("datetime2");

                    b.Property<int>("Telefoonnummer")
                        .HasColumnType("int");

                    b.Property<bool>("Traploper")
                        .HasColumnType("bit");

                    b.Property<bool>("Tweepersoons_Matrashoes")
                        .HasColumnType("bit");

                    b.Property<bool>("Uitpakken")
                        .HasColumnType("bit");

                    b.Property<int>("Uitpakken_Manuren")
                        .HasColumnType("int");

                    b.Property<DateTime>("Vertrekuur_Zaak")
                        .HasColumnType("datetime2");

                    b.Property<int>("Volume")
                        .HasColumnType("int");

                    b.Property<string>("Voornaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Wasmachinebeugel")
                        .HasColumnType("bit");

                    b.HasKey("WerkbonID");

                    b.ToTable("Werkbon");
                });

            modelBuilder.Entity("WerkbonApplicatie.Models.Werkbonpersoneel", b =>
                {
                    b.Property<int>("PersoneelID")
                        .HasColumnType("int");

                    b.Property<int>("WerkbonID")
                        .HasColumnType("int");

                    b.HasKey("PersoneelID", "WerkbonID");

                    b.HasIndex("WerkbonID");

                    b.ToTable("Werkbonpersoneel");
                });

            modelBuilder.Entity("WerkbonApplicatie.Models.Werkbonpersoneel", b =>
                {
                    b.HasOne("WerkbonApplicatie.Models.Personeel", "personeel")
                        .WithMany()
                        .HasForeignKey("PersoneelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WerkbonApplicatie.Models.Werkbon", "werkbon")
                        .WithMany()
                        .HasForeignKey("WerkbonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
