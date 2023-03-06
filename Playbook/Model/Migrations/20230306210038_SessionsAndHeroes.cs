using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class SessionsAndHeroes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HERO_OWNERSHIPS",
                columns: table => new
                {
                    HERO_OWNERSHIP_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GOLD_COINS = table.Column<int>(type: "int", nullable: false),
                    RATIONS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HERO_OWNERSHIPS", x => x.HERO_OWNERSHIP_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "INVENTORIES",
                columns: table => new
                {
                    INVENTORY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    INVENTORY_STATE = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVENTORIES", x => x.INVENTORY_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "USER_ROLES",
                columns: table => new
                {
                    USER_ROLE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IDENTIFIER = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRIPTION = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_ROLES", x => x.USER_ROLE_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    USER_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    USER_NAME = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PASSWORD = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.USER_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "INVENTORY_HAS_ITEMS_JT",
                columns: table => new
                {
                    INVENTORY_ID = table.Column<int>(type: "int", nullable: false),
                    ITEM_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INVENTORY_HAS_ITEMS_JT", x => new { x.INVENTORY_ID, x.ITEM_ID });
                    table.ForeignKey(
                        name: "FK_INVENTORY_HAS_ITEMS_JT_INVENTORIES_INVENTORY_ID",
                        column: x => x.INVENTORY_ID,
                        principalTable: "INVENTORIES",
                        principalColumn: "INVENTORY_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_INVENTORY_HAS_ITEMS_JT_ITEMS_ST_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "ITEMS_ST",
                        principalColumn: "ITEM_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SESSIONS",
                columns: table => new
                {
                    SESSION_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CREATED_AT = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    USER_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SESSIONS", x => x.SESSION_ID);
                    table.ForeignKey(
                        name: "FK_SESSIONS_USERS_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "USER_HAS_ROLES_JT",
                columns: table => new
                {
                    USER_ID = table.Column<int>(type: "int", nullable: false),
                    ROLE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_HAS_ROLES_JT", x => new { x.USER_ID, x.ROLE_ID });
                    table.ForeignKey(
                        name: "FK_USER_HAS_ROLES_JT_USER_ROLES_ROLE_ID",
                        column: x => x.ROLE_ID,
                        principalTable: "USER_ROLES",
                        principalColumn: "USER_ROLE_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USER_HAS_ROLES_JT_USERS_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "USERS",
                        principalColumn: "USER_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HEROES",
                columns: table => new
                {
                    HERO_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ENDURANCE = table.Column<int>(type: "int", nullable: false),
                    COMBAT_SKILL = table.Column<int>(type: "int", nullable: false),
                    SESSION_ID = table.Column<int>(type: "int", nullable: false),
                    HERO_LEVEL = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HERO_OWNERSHIP_ID = table.Column<int>(type: "int", nullable: false),
                    INVENTORY_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HEROES", x => x.HERO_ID);
                    table.ForeignKey(
                        name: "FK_HEROES_HERO_OWNERSHIPS_HERO_OWNERSHIP_ID",
                        column: x => x.HERO_OWNERSHIP_ID,
                        principalTable: "HERO_OWNERSHIPS",
                        principalColumn: "HERO_OWNERSHIP_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HEROES_INVENTORIES_INVENTORY_ID",
                        column: x => x.INVENTORY_ID,
                        principalTable: "INVENTORIES",
                        principalColumn: "INVENTORY_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HEROES_PLAYER_LEVELS_HERO_LEVEL",
                        column: x => x.HERO_LEVEL,
                        principalTable: "PLAYER_LEVELS",
                        principalColumn: "PLAYER_LEVEL",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HEROES_SESSIONS_SESSION_ID",
                        column: x => x.SESSION_ID,
                        principalTable: "SESSIONS",
                        principalColumn: "SESSION_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SESSION_HAS_BOOKS_JT",
                columns: table => new
                {
                    SECTION_ID = table.Column<int>(type: "int", nullable: false),
                    BOOK_ID = table.Column<int>(type: "int", nullable: false),
                    CURRENT_SECTION_ID = table.Column<int>(type: "int", nullable: false),
                    LAST_TIME_PLAYED = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SESSION_HAS_BOOKS_JT", x => new { x.SECTION_ID, x.BOOK_ID });
                    table.ForeignKey(
                        name: "FK_SESSION_HAS_BOOKS_JT_BOOKS_BOOK_ID",
                        column: x => x.BOOK_ID,
                        principalTable: "BOOKS",
                        principalColumn: "BOOK_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SESSION_HAS_BOOKS_JT_SECTIONS_BT_CURRENT_SECTION_ID",
                        column: x => x.CURRENT_SECTION_ID,
                        principalTable: "SECTIONS_BT",
                        principalColumn: "SECTION_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SESSION_HAS_BOOKS_JT_SESSIONS_SECTION_ID",
                        column: x => x.SECTION_ID,
                        principalTable: "SESSIONS",
                        principalColumn: "SESSION_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "USER_ROLES",
                columns: new[] { "USER_ROLE_ID", "DESCRIPTION", "IDENTIFIER" },
                values: new object[] { 1, "Simple User", "User" });

            migrationBuilder.InsertData(
                table: "USER_ROLES",
                columns: new[] { "USER_ROLE_ID", "DESCRIPTION", "IDENTIFIER" },
                values: new object[] { 2, "Administrator", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_HEROES_HERO_LEVEL",
                table: "HEROES",
                column: "HERO_LEVEL");

            migrationBuilder.CreateIndex(
                name: "IX_HEROES_HERO_OWNERSHIP_ID",
                table: "HEROES",
                column: "HERO_OWNERSHIP_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HEROES_INVENTORY_ID",
                table: "HEROES",
                column: "INVENTORY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HEROES_SESSION_ID",
                table: "HEROES",
                column: "SESSION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_INVENTORY_HAS_ITEMS_JT_ITEM_ID",
                table: "INVENTORY_HAS_ITEMS_JT",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SESSION_HAS_BOOKS_JT_BOOK_ID",
                table: "SESSION_HAS_BOOKS_JT",
                column: "BOOK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SESSION_HAS_BOOKS_JT_CURRENT_SECTION_ID",
                table: "SESSION_HAS_BOOKS_JT",
                column: "CURRENT_SECTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SESSIONS_USER_ID",
                table: "SESSIONS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_HAS_ROLES_JT_ROLE_ID",
                table: "USER_HAS_ROLES_JT",
                column: "ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_ROLES_IDENTIFIER",
                table: "USER_ROLES",
                column: "IDENTIFIER",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_USERS_USER_NAME",
                table: "USERS",
                column: "USER_NAME",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HEROES");

            migrationBuilder.DropTable(
                name: "INVENTORY_HAS_ITEMS_JT");

            migrationBuilder.DropTable(
                name: "SESSION_HAS_BOOKS_JT");

            migrationBuilder.DropTable(
                name: "USER_HAS_ROLES_JT");

            migrationBuilder.DropTable(
                name: "HERO_OWNERSHIPS");

            migrationBuilder.DropTable(
                name: "INVENTORIES");

            migrationBuilder.DropTable(
                name: "SESSIONS");

            migrationBuilder.DropTable(
                name: "USER_ROLES");

            migrationBuilder.DropTable(
                name: "USERS");
        }
    }
}
