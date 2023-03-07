using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class SectionHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SESSION_HAS_BOOKS_JT_SECTIONS_BT_CURRENT_SECTION_ID",
                table: "SESSION_HAS_BOOKS_JT");

            migrationBuilder.DropIndex(
                name: "IX_SESSION_HAS_BOOKS_JT_CURRENT_SECTION_ID",
                table: "SESSION_HAS_BOOKS_JT");

            migrationBuilder.DropColumn(
                name: "CURRENT_SECTION_ID",
                table: "SESSION_HAS_BOOKS_JT");

            migrationBuilder.DropColumn(
                name: "LAST_TIME_PLAYED",
                table: "SESSION_HAS_BOOKS_JT");

            migrationBuilder.CreateTable(
                name: "SB_HAS_SECTIONS_JT",
                columns: table => new
                {
                    SESSION_ID = table.Column<int>(type: "int", nullable: false),
                    BOOK_ID = table.Column<int>(type: "int", nullable: false),
                    SECTION_ID = table.Column<int>(type: "int", nullable: false),
                    TIMESTAMP = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SB_HAS_SECTIONS_JT", x => new { x.SESSION_ID, x.BOOK_ID, x.SECTION_ID, x.TIMESTAMP });
                    table.ForeignKey(
                        name: "FK_SB_HAS_SECTIONS_JT_SECTIONS_BT_SECTION_ID",
                        column: x => x.SECTION_ID,
                        principalTable: "SECTIONS_BT",
                        principalColumn: "SECTION_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SB_HAS_SECTIONS_JT_SESSION_HAS_BOOKS_JT_SESSION_ID_BOOK_ID",
                        columns: x => new { x.SESSION_ID, x.BOOK_ID },
                        principalTable: "SESSION_HAS_BOOKS_JT",
                        principalColumns: new[] { "SECTION_ID", "BOOK_ID" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SB_HAS_SECTIONS_JT_SECTION_ID",
                table: "SB_HAS_SECTIONS_JT",
                column: "SECTION_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SB_HAS_SECTIONS_JT");

            migrationBuilder.AddColumn<int>(
                name: "CURRENT_SECTION_ID",
                table: "SESSION_HAS_BOOKS_JT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LAST_TIME_PLAYED",
                table: "SESSION_HAS_BOOKS_JT",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_SESSION_HAS_BOOKS_JT_CURRENT_SECTION_ID",
                table: "SESSION_HAS_BOOKS_JT",
                column: "CURRENT_SECTION_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SESSION_HAS_BOOKS_JT_SECTIONS_BT_CURRENT_SECTION_ID",
                table: "SESSION_HAS_BOOKS_JT",
                column: "CURRENT_SECTION_ID",
                principalTable: "SECTIONS_BT",
                principalColumn: "SECTION_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
