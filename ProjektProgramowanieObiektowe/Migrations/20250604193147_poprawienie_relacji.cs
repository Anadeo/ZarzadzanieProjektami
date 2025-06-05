using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektProgramowanieObiektowe.Migrations
{
    /// <inheritdoc />
    public partial class poprawienie_relacji : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_przypisania_pracownicy_id_pracownik1",
                table: "przypisania");

            migrationBuilder.DropForeignKey(
                name: "FK_przypisania_projekty_id_projekt1",
                table: "przypisania");

            migrationBuilder.DropPrimaryKey(
                name: "PK_przypisania",
                table: "przypisania");

            migrationBuilder.DropIndex(
                name: "IX_przypisania_id_pracownik1",
                table: "przypisania");

            migrationBuilder.DropIndex(
                name: "IX_przypisania_id_projekt1",
                table: "przypisania");

            migrationBuilder.DropColumn(
                name: "id_pracownik1",
                table: "przypisania");

            migrationBuilder.DropColumn(
                name: "id_projekt1",
                table: "przypisania");

            migrationBuilder.AlterColumn<int>(
                name: "id_projekt",
                table: "przypisania",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_przypisania",
                table: "przypisania",
                columns: new[] { "id_projekt", "id_pracownik" });

            migrationBuilder.CreateIndex(
                name: "IX_przypisania_id_pracownik",
                table: "przypisania",
                column: "id_pracownik");

            migrationBuilder.AddForeignKey(
                name: "FK_przypisania_pracownicy_id_pracownik",
                table: "przypisania",
                column: "id_pracownik",
                principalTable: "pracownicy",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_przypisania_projekty_id_projekt",
                table: "przypisania",
                column: "id_projekt",
                principalTable: "projekty",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_przypisania_pracownicy_id_pracownik",
                table: "przypisania");

            migrationBuilder.DropForeignKey(
                name: "FK_przypisania_projekty_id_projekt",
                table: "przypisania");

            migrationBuilder.DropPrimaryKey(
                name: "PK_przypisania",
                table: "przypisania");

            migrationBuilder.DropIndex(
                name: "IX_przypisania_id_pracownik",
                table: "przypisania");

            migrationBuilder.AlterColumn<int>(
                name: "id_projekt",
                table: "przypisania",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "id_pracownik1",
                table: "przypisania",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_projekt1",
                table: "przypisania",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_przypisania",
                table: "przypisania",
                column: "id_projekt");

            migrationBuilder.CreateIndex(
                name: "IX_przypisania_id_pracownik1",
                table: "przypisania",
                column: "id_pracownik1");

            migrationBuilder.CreateIndex(
                name: "IX_przypisania_id_projekt1",
                table: "przypisania",
                column: "id_projekt1");

            migrationBuilder.AddForeignKey(
                name: "FK_przypisania_pracownicy_id_pracownik1",
                table: "przypisania",
                column: "id_pracownik1",
                principalTable: "pracownicy",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_przypisania_projekty_id_projekt1",
                table: "przypisania",
                column: "id_projekt1",
                principalTable: "projekty",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
