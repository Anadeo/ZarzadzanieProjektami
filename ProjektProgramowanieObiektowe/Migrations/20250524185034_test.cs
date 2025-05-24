using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektProgramowanieObiektowe.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pracownicy",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    imie = table.Column<string>(type: "TEXT", nullable: false),
                    nazwisko = table.Column<string>(type: "TEXT", nullable: false),
                    data_zatrudnienia = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pracownicy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "projekty",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    czy_gotowy = table.Column<bool>(type: "INTEGER", nullable: false),
                    data_rozpoczecia = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projekty", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "przypisania",
                columns: table => new
                {
                    id_projekt = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    id_pracownik = table.Column<int>(type: "INTEGER", nullable: false),
                    opis_zadania = table.Column<string>(type: "TEXT", nullable: false),
                    czy_skonczono_prace = table.Column<bool>(type: "INTEGER", nullable: false),
                    termin_wykonania = table.Column<DateTime>(type: "TEXT", nullable: false),
                    id_projekt1 = table.Column<int>(type: "INTEGER", nullable: false),
                    id_pracownik1 = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_przypisania", x => x.id_projekt);
                    table.ForeignKey(
                        name: "FK_przypisania_pracownicy_id_pracownik1",
                        column: x => x.id_pracownik1,
                        principalTable: "pracownicy",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_przypisania_projekty_id_projekt1",
                        column: x => x.id_projekt1,
                        principalTable: "projekty",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_przypisania_id_pracownik1",
                table: "przypisania",
                column: "id_pracownik1");

            migrationBuilder.CreateIndex(
                name: "IX_przypisania_id_projekt1",
                table: "przypisania",
                column: "id_projekt1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "przypisania");

            migrationBuilder.DropTable(
                name: "pracownicy");

            migrationBuilder.DropTable(
                name: "projekty");
        }
    }
}
