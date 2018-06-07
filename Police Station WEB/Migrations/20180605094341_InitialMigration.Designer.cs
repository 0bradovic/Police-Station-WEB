﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoliceStationWebData;

namespace PoliceStationWEB.Migrations
{
    [DbContext(typeof(PoliceStationWebDataContext))]
    [Migration("20180605094341_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PoliceStationWebData.AlarmniSistem", b =>
                {
                    b.Property<int>("Serijski_br")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datum_Atesta");

                    b.Property<DateTime>("Datum_Poslednjeg_Atesta");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("Godina_proizvodnje");

                    b.Property<string>("Model");

                    b.Property<string>("Opis_servisiranja");

                    b.Property<string>("Proizvodjac");

                    b.Property<string>("Tip");

                    b.HasKey("Serijski_br");

                    b.ToTable("AlarmniSistem_");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AlarmniSistem");
                });

            modelBuilder.Entity("PoliceStationWebData.Cin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv_cina");

                    b.HasKey("ID");

                    b.ToTable("Cin_");
                });

            modelBuilder.Entity("PoliceStationWebData.Objekat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<int>("Br_telefona");

                    b.Property<DateTime>("Datum_instalacije");

                    b.Property<int>("ID_Stanice");

                    b.Property<string>("Ime");

                    b.Property<int?>("InstaliranAlarmniSisSerijski_br");

                    b.Property<int?>("NadzireStanicaID");

                    b.Property<int>("Povrsina");

                    b.Property<string>("Prezime");

                    b.Property<int>("Serijski_br_alarma");

                    b.Property<string>("Tip");

                    b.HasKey("ID");

                    b.HasIndex("InstaliranAlarmniSisSerijski_br");

                    b.HasIndex("NadzireStanicaID");

                    b.ToTable("Objekat_");
                });

            modelBuilder.Entity("PoliceStationWebData.Patrola", b =>
                {
                    b.Property<int>("Redni_br")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ID_Objekta");

                    b.Property<int>("ID_Vodje");

                    b.Property<int?>("ObjekatID");

                    b.Property<string>("Opis");

                    b.Property<int>("Reg_oznaka_vozila");

                    b.Property<DateTime>("Vreme");

                    b.HasKey("Redni_br");

                    b.HasIndex("ObjekatID");

                    b.ToTable("Patrola_");
                });

            modelBuilder.Entity("PoliceStationWebData.Policajac", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<int?>("CinID");

                    b.Property<DateTime>("Datum_diplomiranja");

                    b.Property<DateTime>("Datum_rodj");

                    b.Property<DateTime>("Datum_unapredjenja");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("ID_Cina");

                    b.Property<int>("ID_Stanice");

                    b.Property<int>("ID_Uprave");

                    b.Property<int>("ID_Ustanove");

                    b.Property<string>("Ime_roditelja");

                    b.Property<int>("JMBG");

                    b.Property<string>("Licno_ime");

                    b.Property<int>("Oblast");

                    b.Property<string>("Pol")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<int?>("PolicijskaStanicaID");

                    b.Property<string>("Prezime");

                    b.Property<int>("Tip");

                    b.Property<int?>("UpravaID");

                    b.Property<int?>("UstanovaID");

                    b.HasKey("ID");

                    b.HasIndex("CinID");

                    b.HasIndex("PolicijskaStanicaID");

                    b.HasIndex("UpravaID");

                    b.HasIndex("UstanovaID");

                    b.ToTable("Policajac_");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Policajac");
                });

            modelBuilder.Entity("PoliceStationWebData.PolicijskaStanica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<DateTime>("Datum_osnivanja");

                    b.Property<int>("ID_Sefa");

                    b.Property<int>("ID_Uprave");

                    b.Property<int>("ID_Zamenika");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opstina");

                    b.Property<int?>("PripadaUpraviID");

                    b.Property<int?>("SefStaniceID");

                    b.Property<int?>("ZamenikStaniceID");

                    b.HasKey("ID");

                    b.HasIndex("PripadaUpraviID");

                    b.HasIndex("SefStaniceID");

                    b.HasIndex("ZamenikStaniceID");

                    b.ToTable("PolicijskaStanica_");
                });

            modelBuilder.Entity("PoliceStationWebData.Skola", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<int>("Br_telefona");

                    b.Property<string>("Ime");

                    b.Property<string>("Naziv");

                    b.Property<string>("Prezime");

                    b.Property<string>("Tip_skole");

                    b.HasKey("ID");

                    b.ToTable("Skola_");
                });

            modelBuilder.Entity("PoliceStationWebData.TehnickoLice", b =>
                {
                    b.Property<string>("Ime")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Serijski_br_alarmaSerijski_br");

                    b.HasKey("Ime");

                    b.HasIndex("Serijski_br_alarmaSerijski_br");

                    b.ToTable("TehnickoLice_");
                });

            modelBuilder.Entity("PoliceStationWebData.Ulica", b =>
                {
                    b.Property<string>("Ulica_naziv")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ID_Policajca");

                    b.Property<int?>("PozornikID");

                    b.HasKey("Ulica_naziv");

                    b.HasIndex("PozornikID");

                    b.ToTable("Ulica_");
                });

            modelBuilder.Entity("PoliceStationWebData.Uprava", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Grad");

                    b.Property<int>("ID_Nacelnika");

                    b.Property<int?>("NacelnikUpraveID");

                    b.HasKey("ID");

                    b.HasIndex("NacelnikUpraveID");

                    b.ToTable("Uprava_");
                });

            modelBuilder.Entity("PoliceStationWebData.Ustanova", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv_ustanove");

                    b.Property<string>("Tip");

                    b.HasKey("ID");

                    b.ToTable("Ustanova_");
                });

            modelBuilder.Entity("PoliceStationWebData.Vozilo", b =>
                {
                    b.Property<string>("Reg_oznaka")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Boja");

                    b.Property<string>("Model");

                    b.Property<int?>("PosedujeStanicaID");

                    b.Property<string>("Proizvodjac");

                    b.Property<string>("Tip");

                    b.Property<int?>("VoziVoziloRedni_br");

                    b.HasKey("Reg_oznaka");

                    b.HasIndex("PosedujeStanicaID");

                    b.HasIndex("VoziVoziloRedni_br");

                    b.ToTable("Vozilo_");
                });

            modelBuilder.Entity("PoliceStationWebData.Pokretni", b =>
                {
                    b.HasBaseType("PoliceStationWebData.AlarmniSistem");

                    b.Property<int>("Tezina");

                    b.ToTable("Pokretni");

                    b.HasDiscriminator().HasValue("Pokretni");
                });

            modelBuilder.Entity("PoliceStationWebData.Toplotni", b =>
                {
                    b.HasBaseType("PoliceStationWebData.AlarmniSistem");

                    b.Property<int>("Horizontalna_rez");

                    b.Property<int>("Vertikalna_rez");

                    b.ToTable("Toplotni");

                    b.HasDiscriminator().HasValue("Toplotni");
                });

            modelBuilder.Entity("PoliceStationWebData.Ultrazvucni", b =>
                {
                    b.HasBaseType("PoliceStationWebData.AlarmniSistem");

                    b.Property<int>("Frekvencija");

                    b.ToTable("Ultrazvucni");

                    b.HasDiscriminator().HasValue("Ultrazvucni");
                });

            modelBuilder.Entity("PoliceStationWebData.Ostali", b =>
                {
                    b.HasBaseType("PoliceStationWebData.Policajac");

                    b.Property<int>("Redni_br_patrole");

                    b.ToTable("Ostali");

                    b.HasDiscriminator().HasValue("Ostali");
                });

            modelBuilder.Entity("PoliceStationWebData.Pozornik", b =>
                {
                    b.HasBaseType("PoliceStationWebData.Policajac");


                    b.ToTable("Pozornik");

                    b.HasDiscriminator().HasValue("Pozornik");
                });

            modelBuilder.Entity("PoliceStationWebData.Skolski", b =>
                {
                    b.HasBaseType("PoliceStationWebData.Policajac");

                    b.Property<int>("ID_Skole");

                    b.Property<int?>("RadiUSkoliID");

                    b.HasIndex("RadiUSkoliID");

                    b.ToTable("Skolski");

                    b.HasDiscriminator().HasValue("Skolski");
                });

            modelBuilder.Entity("PoliceStationWebData.VanredneSituacije", b =>
                {
                    b.HasBaseType("PoliceStationWebData.Policajac");

                    b.Property<DateTime>("Datum_kursa");

                    b.Property<DateTime>("Datum_sertifikata");

                    b.Property<string>("Kurs");

                    b.Property<string>("Naziv_vestine");

                    b.Property<string>("Sertifikat");

                    b.ToTable("VanredneSituacije");

                    b.HasDiscriminator().HasValue("VanredneSituacije");
                });

            modelBuilder.Entity("PoliceStationWebData.Objekat", b =>
                {
                    b.HasOne("PoliceStationWebData.AlarmniSistem", "InstaliranAlarmniSis")
                        .WithMany()
                        .HasForeignKey("InstaliranAlarmniSisSerijski_br");

                    b.HasOne("PoliceStationWebData.PolicijskaStanica", "NadzireStanica")
                        .WithMany("Objekti")
                        .HasForeignKey("NadzireStanicaID");
                });

            modelBuilder.Entity("PoliceStationWebData.Patrola", b =>
                {
                    b.HasOne("PoliceStationWebData.Objekat")
                        .WithMany("Patrole")
                        .HasForeignKey("ObjekatID");
                });

            modelBuilder.Entity("PoliceStationWebData.Policajac", b =>
                {
                    b.HasOne("PoliceStationWebData.Cin")
                        .WithMany("Policajci")
                        .HasForeignKey("CinID");

                    b.HasOne("PoliceStationWebData.PolicijskaStanica")
                        .WithMany("Policajci")
                        .HasForeignKey("PolicijskaStanicaID");

                    b.HasOne("PoliceStationWebData.Uprava")
                        .WithMany("Policajci")
                        .HasForeignKey("UpravaID");

                    b.HasOne("PoliceStationWebData.Ustanova")
                        .WithMany("Policajci")
                        .HasForeignKey("UstanovaID");
                });

            modelBuilder.Entity("PoliceStationWebData.PolicijskaStanica", b =>
                {
                    b.HasOne("PoliceStationWebData.Uprava", "PripadaUpravi")
                        .WithMany("PolicijskeStanice")
                        .HasForeignKey("PripadaUpraviID");

                    b.HasOne("PoliceStationWebData.Policajac", "SefStanice")
                        .WithMany()
                        .HasForeignKey("SefStaniceID");

                    b.HasOne("PoliceStationWebData.Policajac", "ZamenikStanice")
                        .WithMany()
                        .HasForeignKey("ZamenikStaniceID");
                });

            modelBuilder.Entity("PoliceStationWebData.TehnickoLice", b =>
                {
                    b.HasOne("PoliceStationWebData.AlarmniSistem", "Serijski_br_alarma")
                        .WithMany()
                        .HasForeignKey("Serijski_br_alarmaSerijski_br");
                });

            modelBuilder.Entity("PoliceStationWebData.Ulica", b =>
                {
                    b.HasOne("PoliceStationWebData.Pozornik")
                        .WithMany("Ulice")
                        .HasForeignKey("PozornikID");
                });

            modelBuilder.Entity("PoliceStationWebData.Uprava", b =>
                {
                    b.HasOne("PoliceStationWebData.Policajac", "NacelnikUprave")
                        .WithMany()
                        .HasForeignKey("NacelnikUpraveID");
                });

            modelBuilder.Entity("PoliceStationWebData.Vozilo", b =>
                {
                    b.HasOne("PoliceStationWebData.PolicijskaStanica", "PosedujeStanica")
                        .WithMany("Vozila")
                        .HasForeignKey("PosedujeStanicaID");

                    b.HasOne("PoliceStationWebData.Patrola", "VoziVozilo")
                        .WithMany()
                        .HasForeignKey("VoziVoziloRedni_br");
                });

            modelBuilder.Entity("PoliceStationWebData.Skolski", b =>
                {
                    b.HasOne("PoliceStationWebData.Skola", "RadiUSkoli")
                        .WithMany("Skolski")
                        .HasForeignKey("RadiUSkoliID");
                });
#pragma warning restore 612, 618
        }
    }
}
