using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_Visit_To_Georgia.Migrations
{
    /// <inheritdoc />
    public partial class InitBokningar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bokningar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Namn = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Tid = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    AntalPersoner = table.Column<int>(type: "INTEGER", nullable: false),
                    Kommentar = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bokningar", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bokningar");
        }
    }
}
