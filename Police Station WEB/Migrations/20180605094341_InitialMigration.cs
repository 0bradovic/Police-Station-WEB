using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PoliceStationWEB.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlarmniSistem_",
                columns: table => new
                {
                    Serijski_br = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Godina_proizvodnje = table.Column<int>(nullable: false),
                    Proizvodjac = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Opis_servisiranja = table.Column<string>(nullable: true),
                    Tip = table.Column<string>(nullable: true),
                    Datum_Atesta = table.Column<DateTime>(nullable: false),
                    Datum_Poslednjeg_Atesta = table.Column<DateTime>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Tezina = table.Column<int>(nullable: true),
                    Horizontalna_rez = table.Column<int>(nullable: true),
                    Vertikalna_rez = table.Column<int>(nullable: true),
                    Frekvencija = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlarmniSistem_", x => x.Serijski_br);
                });

            migrationBuilder.CreateTable(
                name: "Cin_",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv_cina = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cin_", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Skola_",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tip_skole = table.Column<string>(nullable: true),
                    Naziv = table.Column<string>(nullable: true),
                    Br_telefona = table.Column<int>(nullable: false),
                    Adresa = table.Column<string>(nullable: true),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skola_", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ustanova_",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv_ustanove = table.Column<string>(nullable: true),
                    Tip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ustanova_", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TehnickoLice_",
                columns: table => new
                {
                    Serijski_br_alarmaSerijski_br = table.Column<int>(nullable: true),
                    Ime = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TehnickoLice_", x => x.Ime);
                    table.ForeignKey(
                        name: "FK_TehnickoLice__AlarmniSistem__Serijski_br_alarmaSerijski_br",
                        column: x => x.Serijski_br_alarmaSerijski_br,
                        principalTable: "AlarmniSistem_",
                        principalColumn: "Serijski_br",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Objekat_",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tip = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    Povrsina = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Br_telefona = table.Column<int>(nullable: false),
                    Serijski_br_alarma = table.Column<int>(nullable: false),
                    Datum_instalacije = table.Column<DateTime>(nullable: false),
                    ID_Stanice = table.Column<int>(nullable: false),
                    InstaliranAlarmniSisSerijski_br = table.Column<int>(nullable: true),
                    NadzireStanicaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objekat_", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Objekat__AlarmniSistem__InstaliranAlarmniSisSerijski_br",
                        column: x => x.InstaliranAlarmniSisSerijski_br,
                        principalTable: "AlarmniSistem_",
                        principalColumn: "Serijski_br",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patrola_",
                columns: table => new
                {
                    Redni_br = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_Vodje = table.Column<int>(nullable: false),
                    Reg_oznaka_vozila = table.Column<int>(nullable: false),
                    ID_Objekta = table.Column<int>(nullable: false),
                    Vreme = table.Column<DateTime>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    ObjekatID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patrola_", x => x.Redni_br);
                    table.ForeignKey(
                        name: "FK_Patrola__Objekat__ObjekatID",
                        column: x => x.ObjekatID,
                        principalTable: "Objekat_",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Policajac_",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Licno_ime = table.Column<string>(nullable: true),
                    Tip = table.Column<int>(nullable: false),
                    Ime_roditelja = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    JMBG = table.Column<int>(nullable: false),
                    Pol = table.Column<string>(nullable: false),
                    Datum_rodj = table.Column<DateTime>(nullable: false),
                    Adresa = table.Column<string>(nullable: true),
                    Datum_diplomiranja = table.Column<DateTime>(nullable: false),
                    Datum_unapredjenja = table.Column<DateTime>(nullable: false),
                    Oblast = table.Column<int>(nullable: false),
                    ID_Ustanove = table.Column<int>(nullable: false),
                    ID_Cina = table.Column<int>(nullable: false),
                    ID_Uprave = table.Column<int>(nullable: false),
                    ID_Stanice = table.Column<int>(nullable: false),
                    CinID = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    PolicijskaStanicaID = table.Column<int>(nullable: true),
                    UpravaID = table.Column<int>(nullable: true),
                    UstanovaID = table.Column<int>(nullable: true),
                    Redni_br_patrole = table.Column<int>(nullable: true),
                    ID_Skole = table.Column<int>(nullable: true),
                    RadiUSkoliID = table.Column<int>(nullable: true),
                    Naziv_vestine = table.Column<string>(nullable: true),
                    Kurs = table.Column<string>(nullable: true),
                    Datum_kursa = table.Column<DateTime>(nullable: true),
                    Sertifikat = table.Column<string>(nullable: true),
                    Datum_sertifikata = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policajac_", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Policajac__Cin__CinID",
                        column: x => x.CinID,
                        principalTable: "Cin_",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Policajac__Ustanova__UstanovaID",
                        column: x => x.UstanovaID,
                        principalTable: "Ustanova_",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Policajac__Skola__RadiUSkoliID",
                        column: x => x.RadiUSkoliID,
                        principalTable: "Skola_",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ulica_",
                columns: table => new
                {
                    ID_Policajca = table.Column<int>(nullable: false),
                    Ulica_naziv = table.Column<string>(nullable: false),
                    PozornikID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ulica_", x => x.Ulica_naziv);
                    table.ForeignKey(
                        name: "FK_Ulica__Policajac__PozornikID",
                        column: x => x.PozornikID,
                        principalTable: "Policajac_",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uprava_",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Grad = table.Column<string>(nullable: true),
                    ID_Nacelnika = table.Column<int>(nullable: false),
                    NacelnikUpraveID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uprava_", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Uprava__Policajac__NacelnikUpraveID",
                        column: x => x.NacelnikUpraveID,
                        principalTable: "Policajac_",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PolicijskaStanica_",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adresa = table.Column<string>(nullable: true),
                    Opstina = table.Column<string>(nullable: true),
                    Naziv = table.Column<string>(nullable: true),
                    Datum_osnivanja = table.Column<DateTime>(nullable: false),
                    ID_Sefa = table.Column<int>(nullable: false),
                    SefStaniceID = table.Column<int>(nullable: true),
                    ZamenikStaniceID = table.Column<int>(nullable: true),
                    ID_Zamenika = table.Column<int>(nullable: false),
                    ID_Uprave = table.Column<int>(nullable: false),
                    PripadaUpraviID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicijskaStanica_", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PolicijskaStanica__Uprava__PripadaUpraviID",
                        column: x => x.PripadaUpraviID,
                        principalTable: "Uprava_",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicijskaStanica__Policajac__SefStaniceID",
                        column: x => x.SefStaniceID,
                        principalTable: "Policajac_",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicijskaStanica__Policajac__ZamenikStaniceID",
                        column: x => x.ZamenikStaniceID,
                        principalTable: "Policajac_",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vozilo_",
                columns: table => new
                {
                    Reg_oznaka = table.Column<string>(nullable: false),
                    Boja = table.Column<string>(nullable: true),
                    Tip = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Proizvodjac = table.Column<string>(nullable: true),
                    VoziVoziloRedni_br = table.Column<int>(nullable: true),
                    PosedujeStanicaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozilo_", x => x.Reg_oznaka);
                    table.ForeignKey(
                        name: "FK_Vozilo__PolicijskaStanica__PosedujeStanicaID",
                        column: x => x.PosedujeStanicaID,
                        principalTable: "PolicijskaStanica_",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vozilo__Patrola__VoziVoziloRedni_br",
                        column: x => x.VoziVoziloRedni_br,
                        principalTable: "Patrola_",
                        principalColumn: "Redni_br",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Objekat__InstaliranAlarmniSisSerijski_br",
                table: "Objekat_",
                column: "InstaliranAlarmniSisSerijski_br");

            migrationBuilder.CreateIndex(
                name: "IX_Objekat__NadzireStanicaID",
                table: "Objekat_",
                column: "NadzireStanicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Patrola__ObjekatID",
                table: "Patrola_",
                column: "ObjekatID");

            migrationBuilder.CreateIndex(
                name: "IX_Policajac__CinID",
                table: "Policajac_",
                column: "CinID");

            migrationBuilder.CreateIndex(
                name: "IX_Policajac__PolicijskaStanicaID",
                table: "Policajac_",
                column: "PolicijskaStanicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Policajac__UpravaID",
                table: "Policajac_",
                column: "UpravaID");

            migrationBuilder.CreateIndex(
                name: "IX_Policajac__UstanovaID",
                table: "Policajac_",
                column: "UstanovaID");

            migrationBuilder.CreateIndex(
                name: "IX_Policajac__RadiUSkoliID",
                table: "Policajac_",
                column: "RadiUSkoliID");

            migrationBuilder.CreateIndex(
                name: "IX_PolicijskaStanica__PripadaUpraviID",
                table: "PolicijskaStanica_",
                column: "PripadaUpraviID");

            migrationBuilder.CreateIndex(
                name: "IX_PolicijskaStanica__SefStaniceID",
                table: "PolicijskaStanica_",
                column: "SefStaniceID");

            migrationBuilder.CreateIndex(
                name: "IX_PolicijskaStanica__ZamenikStaniceID",
                table: "PolicijskaStanica_",
                column: "ZamenikStaniceID");

            migrationBuilder.CreateIndex(
                name: "IX_TehnickoLice__Serijski_br_alarmaSerijski_br",
                table: "TehnickoLice_",
                column: "Serijski_br_alarmaSerijski_br");

            migrationBuilder.CreateIndex(
                name: "IX_Ulica__PozornikID",
                table: "Ulica_",
                column: "PozornikID");

            migrationBuilder.CreateIndex(
                name: "IX_Uprava__NacelnikUpraveID",
                table: "Uprava_",
                column: "NacelnikUpraveID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo__PosedujeStanicaID",
                table: "Vozilo_",
                column: "PosedujeStanicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vozilo__VoziVoziloRedni_br",
                table: "Vozilo_",
                column: "VoziVoziloRedni_br");

            migrationBuilder.AddForeignKey(
                name: "FK_Objekat__PolicijskaStanica__NadzireStanicaID",
                table: "Objekat_",
                column: "NadzireStanicaID",
                principalTable: "PolicijskaStanica_",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Policajac__PolicijskaStanica__PolicijskaStanicaID",
                table: "Policajac_",
                column: "PolicijskaStanicaID",
                principalTable: "PolicijskaStanica_",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Policajac__Uprava__UpravaID",
                table: "Policajac_",
                column: "UpravaID",
                principalTable: "Uprava_",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Policajac__PolicijskaStanica__PolicijskaStanicaID",
                table: "Policajac_");

            migrationBuilder.DropForeignKey(
                name: "FK_Policajac__Cin__CinID",
                table: "Policajac_");

            migrationBuilder.DropForeignKey(
                name: "FK_Policajac__Uprava__UpravaID",
                table: "Policajac_");

            migrationBuilder.DropTable(
                name: "TehnickoLice_");

            migrationBuilder.DropTable(
                name: "Ulica_");

            migrationBuilder.DropTable(
                name: "Vozilo_");

            migrationBuilder.DropTable(
                name: "Patrola_");

            migrationBuilder.DropTable(
                name: "Objekat_");

            migrationBuilder.DropTable(
                name: "AlarmniSistem_");

            migrationBuilder.DropTable(
                name: "PolicijskaStanica_");

            migrationBuilder.DropTable(
                name: "Cin_");

            migrationBuilder.DropTable(
                name: "Uprava_");

            migrationBuilder.DropTable(
                name: "Policajac_");

            migrationBuilder.DropTable(
                name: "Ustanova_");

            migrationBuilder.DropTable(
                name: "Skola_");
        }
    }
}
