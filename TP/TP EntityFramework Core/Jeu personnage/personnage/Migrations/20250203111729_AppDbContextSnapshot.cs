using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace personnage.Migrations
{
    /// <inheritdoc />
    public partial class AppDbContextSnapshot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personnages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pseudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PointsDeVie = table.Column<int>(type: "int", nullable: false),
                    Armure = table.Column<int>(type: "int", nullable: false),
                    Degats = table.Column<int>(type: "int", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kills = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnages", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Personnages",
                columns: new[] { "id", "Armure", "DateCreation", "Degats", "Kills", "PointsDeVie", "Pseudo" },
                values: new object[] { 1, 100, new DateTime(2025, 2, 3, 12, 17, 29, 331, DateTimeKind.Local).AddTicks(3779), 10, 0, 100, "Fuziio" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personnages");
        }
    }
}
