using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RS2_seminarski_tattoostudio.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spol",
                columns: table => new
                {
                    SpolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spol", x => x.SpolId);
                });

            migrationBuilder.CreateTable(
                name: "TipProizvoda",
                columns: table => new
                {
                    TipProizvodaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tipproizovda", x => x.TipProizvodaId);
                });

            migrationBuilder.CreateTable(
                name: "TipTermina",
                columns: table => new
                {
                    TipTerminaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipTermina", x => x.TipTerminaId);
                });

            migrationBuilder.CreateTable(
                name: "Zanimanje",
                columns: table => new
                {
                    ZanimanjeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zanimanje", x => x.ZanimanjeId);
                });

            migrationBuilder.CreateTable(
                name: "Klijent",
                columns: table => new
                {
                    KlijentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpolId = table.Column<int>(type: "int", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "date", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LozinkaHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijent", x => x.KlijentId);
                    table.ForeignKey(
                        name: "fk_klijent_spol",
                        column: x => x.SpolId,
                        principalTable: "Spol",
                        principalColumn: "SpolId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    ProizvodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipProizvodaId = table.Column<int>(type: "int", nullable: true),
                    Cijena = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    Naziv = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.ProizvodId);
                    table.ForeignKey(
                        name: "fk_proizvod_tip",
                        column: x => x.TipProizvodaId,
                        principalTable: "TipProizvoda",
                        principalColumn: "TipProizvodaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uposlenik",
                columns: table => new
                {
                    UposlenikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZanimanjeId = table.Column<int>(type: "int", nullable: true),
                    SpolId = table.Column<int>(type: "int", nullable: true),
                    Ime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LozinkaHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uposlenik", x => x.UposlenikId);
                    table.ForeignKey(
                        name: "fk_uposlenik_spol",
                        column: x => x.SpolId,
                        principalTable: "Spol",
                        principalColumn: "SpolId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_uposlenik_zanimanje",
                        column: x => x.ZanimanjeId,
                        principalTable: "Zanimanje",
                        principalColumn: "ZanimanjeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    NarudzbaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlijentId = table.Column<int>(type: "int", nullable: true),
                    Datum = table.Column<DateTime>(type: "date", nullable: true),
                    UkupniIznos = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsIsporucena = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    IsPlacena = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.NarudzbaId);
                    table.ForeignKey(
                        name: "fk_narudzba_klijent",
                        column: x => x.KlijentId,
                        principalTable: "Klijent",
                        principalColumn: "KlijentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Izvjestaj",
                columns: table => new
                {
                    IzvjestajId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UposlenikId = table.Column<int>(type: "int", nullable: true),
                    Datum = table.Column<DateTime>(type: "date", nullable: true),
                    Detalji = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Izvjestaj", x => x.IzvjestajId);
                    table.ForeignKey(
                        name: "fk_izvjestaj_uposlenik",
                        column: x => x.UposlenikId,
                        principalTable: "Uposlenik",
                        principalColumn: "UposlenikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Obavijest",
                columns: table => new
                {
                    ObavijestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UposlenikId = table.Column<int>(type: "int", nullable: true),
                    Datum = table.Column<DateTime>(type: "date", nullable: true),
                    Naslov = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Sadrzaj = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijest", x => x.ObavijestId);
                    table.ForeignKey(
                        name: "fk_obavijest_uposlenik",
                        column: x => x.UposlenikId,
                        principalTable: "Uposlenik",
                        principalColumn: "UposlenikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Portfolio",
                columns: table => new
                {
                    PortfolioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UposlenikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolio", x => x.PortfolioId);
                    table.ForeignKey(
                        name: "FK__Portfolio__Uposl__44FF419A",
                        column: x => x.UposlenikId,
                        principalTable: "Uposlenik",
                        principalColumn: "UposlenikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Termin",
                columns: table => new
                {
                    TerminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlijentId = table.Column<int>(type: "int", nullable: true),
                    UposlenikId = table.Column<int>(type: "int", nullable: true),
                    Datum = table.Column<DateTime>(type: "date", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Cijena = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TipTerminaId = table.Column<int>(type: "int", nullable: true),
                    IsOdobren = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    IsPlacen = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    IsOtkazan = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Komentar = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termin", x => x.TerminId);
                    table.ForeignKey(
                        name: "fk_klijent_termin",
                        column: x => x.KlijentId,
                        principalTable: "Klijent",
                        principalColumn: "KlijentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_termin_tip",
                        column: x => x.TipTerminaId,
                        principalTable: "TipTermina",
                        principalColumn: "TipTerminaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_uposlenik_termin",
                        column: x => x.UposlenikId,
                        principalTable: "Uposlenik",
                        principalColumn: "UposlenikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StavkeNarudzbe",
                columns: table => new
                {
                    StavkeNarudzbeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NarudzbaId = table.Column<int>(type: "int", nullable: true),
                    ProizvodId = table.Column<int>(type: "int", nullable: true),
                    Kolicina = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkeNarudzbe", x => x.StavkeNarudzbeId);
                    table.ForeignKey(
                        name: "fk_narudzba_proizvod",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_narudzbaproizvod",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzba",
                        principalColumn: "NarudzbaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StavkePortfolia",
                columns: table => new
                {
                    StavkaPortfoliaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PortfolioId = table.Column<int>(type: "int", nullable: true),
                    Datum = table.Column<DateTime>(type: "date", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_stavkaportfoliaid", x => x.StavkaPortfoliaId);
                    table.ForeignKey(
                        name: "fk_stavka_portfolio",
                        column: x => x.PortfolioId,
                        principalTable: "Portfolio",
                        principalColumn: "PortfolioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Izvjestaj_UposlenikId",
                table: "Izvjestaj",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Klijent_SpolId",
                table: "Klijent",
                column: "SpolId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KlijentId",
                table: "Narudzba",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijest_UposlenikId",
                table: "Obavijest",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "fk_uposlenik_portfolio",
                table: "Portfolio",
                column: "UposlenikId",
                unique: true,
                filter: "[UposlenikId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_TipProizvodaId",
                table: "Proizvod",
                column: "TipProizvodaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeNarudzbe_NarudzbaId",
                table: "StavkeNarudzbe",
                column: "NarudzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeNarudzbe_ProizvodId",
                table: "StavkeNarudzbe",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkePortfolia_PortfolioId",
                table: "StavkePortfolia",
                column: "PortfolioId");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_KlijentId",
                table: "Termin",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_TipTerminaId",
                table: "Termin",
                column: "TipTerminaId");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_UposlenikId",
                table: "Termin",
                column: "UposlenikId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_SpolId",
                table: "Uposlenik",
                column: "SpolId");

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenik_ZanimanjeId",
                table: "Uposlenik",
                column: "ZanimanjeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Izvjestaj");

            migrationBuilder.DropTable(
                name: "Obavijest");

            migrationBuilder.DropTable(
                name: "StavkeNarudzbe");

            migrationBuilder.DropTable(
                name: "StavkePortfolia");

            migrationBuilder.DropTable(
                name: "Termin");

            migrationBuilder.DropTable(
                name: "Proizvod");

            migrationBuilder.DropTable(
                name: "Narudzba");

            migrationBuilder.DropTable(
                name: "Portfolio");

            migrationBuilder.DropTable(
                name: "TipTermina");

            migrationBuilder.DropTable(
                name: "TipProizvoda");

            migrationBuilder.DropTable(
                name: "Klijent");

            migrationBuilder.DropTable(
                name: "Uposlenik");

            migrationBuilder.DropTable(
                name: "Spol");

            migrationBuilder.DropTable(
                name: "Zanimanje");
        }
    }
}
