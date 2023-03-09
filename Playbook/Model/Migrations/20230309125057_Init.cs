using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Model.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ABILITIES",
                columns: table => new
                {
                    ABILITY_TYPE = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRIPTION = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IMAGE_URL = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABILITIES", x => x.ABILITY_TYPE);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AUTHORS",
                columns: table => new
                {
                    AUTHOR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FIRST_NAME = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LAST_NAME = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AUTHORS", x => x.AUTHOR_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BOOKS",
                columns: table => new
                {
                    BOOK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TITLE = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IMAGE_URL = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOOKS", x => x.BOOK_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CREATURES",
                columns: table => new
                {
                    CREATURE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CREATURE_TYPE = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    COMBAT_SKILL = table.Column<int>(type: "int", nullable: false),
                    ENDURANCE = table.Column<int>(type: "int", nullable: false),
                    IMAGE_URL = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CREATURES", x => x.CREATURE_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EFFECTS_BT",
                columns: table => new
                {
                    EFFECT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EFFECTS_BT", x => x.EFFECT_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                name: "ITEMS_ST",
                columns: table => new
                {
                    ITEM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRIPTION = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WEIGHT = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IMAGE_URL = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ITEM_TYPE = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEMS_ST", x => x.ITEM_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PLAYER_LEVELS",
                columns: table => new
                {
                    PLAYER_LEVEL = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ABILITY_COUNT = table.Column<int>(type: "int", nullable: false),
                    IMAGE_URL = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLAYER_LEVELS", x => x.PLAYER_LEVEL);
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
                name: "BOOK_HAS_AUTHORS_JT",
                columns: table => new
                {
                    BOOK_ID = table.Column<int>(type: "int", nullable: false),
                    AUTHOR_ID = table.Column<int>(type: "int", nullable: false),
                    OCCUPATION_TYPE = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BOOK_HAS_AUTHORS_JT", x => new { x.BOOK_ID, x.AUTHOR_ID, x.OCCUPATION_TYPE });
                    table.ForeignKey(
                        name: "FK_BOOK_HAS_AUTHORS_JT_AUTHORS_AUTHOR_ID",
                        column: x => x.AUTHOR_ID,
                        principalTable: "AUTHORS",
                        principalColumn: "AUTHOR_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BOOK_HAS_AUTHORS_JT_BOOKS_BOOK_ID",
                        column: x => x.BOOK_ID,
                        principalTable: "BOOKS",
                        principalColumn: "BOOK_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SECTIONS_BT",
                columns: table => new
                {
                    SECTION_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CONTENT = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BOOK_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECTIONS_BT", x => x.SECTION_ID);
                    table.ForeignKey(
                        name: "FK_SECTIONS_BT_BOOKS_BOOK_ID",
                        column: x => x.BOOK_ID,
                        principalTable: "BOOKS",
                        principalColumn: "BOOK_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CREATURE_HAS_ABILITIES_JT",
                columns: table => new
                {
                    CREATURE_ID = table.Column<int>(type: "int", nullable: false),
                    ABILITY_TYPE = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CREATURE_HAS_ABILITIES_JT", x => new { x.CREATURE_ID, x.ABILITY_TYPE });
                    table.ForeignKey(
                        name: "FK_CREATURE_HAS_ABILITIES_JT_ABILITIES_ABILITY_TYPE",
                        column: x => x.ABILITY_TYPE,
                        principalTable: "ABILITIES",
                        principalColumn: "ABILITY_TYPE",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CREATURE_HAS_ABILITIES_JT_CREATURES_CREATURE_ID",
                        column: x => x.CREATURE_ID,
                        principalTable: "CREATURES",
                        principalColumn: "CREATURE_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ABILITY_HAS_EFFECTS_JT",
                columns: table => new
                {
                    ABILITY_TYPE = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EFFECT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABILITY_HAS_EFFECTS_JT", x => new { x.ABILITY_TYPE, x.EFFECT_ID });
                    table.ForeignKey(
                        name: "FK_ABILITY_HAS_EFFECTS_JT_ABILITIES_ABILITY_TYPE",
                        column: x => x.ABILITY_TYPE,
                        principalTable: "ABILITIES",
                        principalColumn: "ABILITY_TYPE",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ABILITY_HAS_EFFECTS_JT_EFFECTS_BT_EFFECT_ID",
                        column: x => x.EFFECT_ID,
                        principalTable: "EFFECTS_BT",
                        principalColumn: "EFFECT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VALUE_CHANGE_EFFECTS_BT",
                columns: table => new
                {
                    EFFECT_ID = table.Column<int>(type: "int", nullable: false),
                    AMOUNT = table.Column<int>(type: "int", nullable: false),
                    DURATION = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VALUE_CHANGE_EFFECTS_BT", x => x.EFFECT_ID);
                    table.ForeignKey(
                        name: "FK_VALUE_CHANGE_EFFECTS_BT_EFFECTS_BT_EFFECT_ID",
                        column: x => x.EFFECT_ID,
                        principalTable: "EFFECTS_BT",
                        principalColumn: "EFFECT_ID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "ITEM_HAS_EFFECTS_JT",
                columns: table => new
                {
                    ITEM_ID = table.Column<int>(type: "int", nullable: false),
                    EFFECT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEM_HAS_EFFECTS_JT", x => new { x.ITEM_ID, x.EFFECT_ID });
                    table.ForeignKey(
                        name: "FK_ITEM_HAS_EFFECTS_JT_EFFECTS_BT_EFFECT_ID",
                        column: x => x.EFFECT_ID,
                        principalTable: "EFFECTS_BT",
                        principalColumn: "EFFECT_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ITEM_HAS_EFFECTS_JT_ITEMS_ST_ITEM_ID",
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
                name: "IMAGE_DECORATORS",
                columns: table => new
                {
                    IMAGE_URL = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SECTION_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMAGE_DECORATORS", x => x.IMAGE_URL);
                    table.ForeignKey(
                        name: "FK_IMAGE_DECORATORS_SECTIONS_BT_SECTION_ID",
                        column: x => x.SECTION_ID,
                        principalTable: "SECTIONS_BT",
                        principalColumn: "SECTION_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RULE_SECTIONS",
                columns: table => new
                {
                    SECTION_ID = table.Column<int>(type: "int", nullable: false),
                    SECTION_TYPE = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RULE_SECTIONS", x => x.SECTION_ID);
                    table.ForeignKey(
                        name: "FK_RULE_SECTIONS_SECTIONS_BT_SECTION_ID",
                        column: x => x.SECTION_ID,
                        principalTable: "SECTIONS_BT",
                        principalColumn: "SECTION_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "COMBAT_SKILL_CHANGE_EFFECTS",
                columns: table => new
                {
                    EFFECT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMBAT_SKILL_CHANGE_EFFECTS", x => x.EFFECT_ID);
                    table.ForeignKey(
                        name: "FK_COMBAT_SKILL_CHANGE_EFFECTS_VALUE_CHANGE_EFFECTS_BT_EFFECT_ID",
                        column: x => x.EFFECT_ID,
                        principalTable: "VALUE_CHANGE_EFFECTS_BT",
                        principalColumn: "EFFECT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ENDURANCE_CHANGE_EFFECTS",
                columns: table => new
                {
                    EFFECT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENDURANCE_CHANGE_EFFECTS", x => x.EFFECT_ID);
                    table.ForeignKey(
                        name: "FK_ENDURANCE_CHANGE_EFFECTS_VALUE_CHANGE_EFFECTS_BT_EFFECT_ID",
                        column: x => x.EFFECT_ID,
                        principalTable: "VALUE_CHANGE_EFFECTS_BT",
                        principalColumn: "EFFECT_ID",
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
                    BOOK_ID = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_SESSION_HAS_BOOKS_JT_SESSIONS_SECTION_ID",
                        column: x => x.SECTION_ID,
                        principalTable: "SESSIONS",
                        principalColumn: "SESSION_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HERO_HAS_ABILITIES_JT",
                columns: table => new
                {
                    HERO_ID = table.Column<int>(type: "int", nullable: false),
                    ABILITY_TYPE = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HERO_HAS_ABILITIES_JT", x => new { x.HERO_ID, x.ABILITY_TYPE });
                    table.ForeignKey(
                        name: "FK_HERO_HAS_ABILITIES_JT_ABILITIES_ABILITY_TYPE",
                        column: x => x.ABILITY_TYPE,
                        principalTable: "ABILITIES",
                        principalColumn: "ABILITY_TYPE",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HERO_HAS_ABILITIES_JT_HEROES_HERO_ID",
                        column: x => x.HERO_ID,
                        principalTable: "HEROES",
                        principalColumn: "HERO_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateTable(
                name: "ABILITY_OUTCOMES",
                columns: table => new
                {
                    OUTCOME_ID = table.Column<int>(type: "int", nullable: false),
                    ABILITY_TYPE = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ABILITY_OUTCOMES", x => x.OUTCOME_ID);
                    table.ForeignKey(
                        name: "FK_ABILITY_OUTCOMES_ABILITIES_ABILITY_TYPE",
                        column: x => x.ABILITY_TYPE,
                        principalTable: "ABILITIES",
                        principalColumn: "ABILITY_TYPE",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ACQUIRE_ITEM_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACQUIRE_ITEM_EVENTS", x => x.EVENT_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AREAS",
                columns: table => new
                {
                    REGION_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AREAS", x => x.REGION_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "REGIONS_BT",
                columns: table => new
                {
                    REGION_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRIPTION = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NAME = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    REGION_TYPE = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AREA_ID = table.Column<int>(type: "int", nullable: true),
                    IMAGE_URL = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REGIONS_BT", x => x.REGION_ID);
                    table.ForeignKey(
                        name: "FK_REGIONS_BT_AREAS_AREA_ID",
                        column: x => x.AREA_ID,
                        principalTable: "AREAS",
                        principalColumn: "REGION_ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "POINTS_OF_INTEREST",
                columns: table => new
                {
                    REGION_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POINTS_OF_INTEREST", x => x.REGION_ID);
                    table.ForeignKey(
                        name: "FK_POINTS_OF_INTEREST_REGIONS_BT_REGION_ID",
                        column: x => x.REGION_ID,
                        principalTable: "REGIONS_BT",
                        principalColumn: "REGION_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "STORY_SECTIONS",
                columns: table => new
                {
                    SECTION_ID = table.Column<int>(type: "int", nullable: false),
                    SECTION_NR = table.Column<int>(type: "int", nullable: false),
                    REGION_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORY_SECTIONS", x => x.SECTION_ID);
                    table.ForeignKey(
                        name: "FK_STORY_SECTIONS_REGIONS_BT_REGION_ID",
                        column: x => x.REGION_ID,
                        principalTable: "REGIONS_BT",
                        principalColumn: "REGION_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_STORY_SECTIONS_SECTIONS_BT_SECTION_ID",
                        column: x => x.SECTION_ID,
                        principalTable: "SECTIONS_BT",
                        principalColumn: "SECTION_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EVENTS_BT",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SECTION_ID = table.Column<int>(type: "int", nullable: false),
                    RANKING = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EVENTS_BT", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_EVENTS_BT_STORY_SECTIONS_SECTION_ID",
                        column: x => x.SECTION_ID,
                        principalTable: "STORY_SECTIONS",
                        principalColumn: "SECTION_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OUTCOMES_BT",
                columns: table => new
                {
                    OUTCOME_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ROOT_SECTION_ID = table.Column<int>(type: "int", nullable: false),
                    SECTION_ID = table.Column<int>(type: "int", nullable: false),
                    CONTENT = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OUTCOMES_BT", x => x.OUTCOME_ID);
                    table.ForeignKey(
                        name: "FK_OUTCOMES_BT_STORY_SECTIONS_ROOT_SECTION_ID",
                        column: x => x.ROOT_SECTION_ID,
                        principalTable: "STORY_SECTIONS",
                        principalColumn: "SECTION_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OUTCOMES_BT_STORY_SECTIONS_SECTION_ID",
                        column: x => x.SECTION_ID,
                        principalTable: "STORY_SECTIONS",
                        principalColumn: "SECTION_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CHANGE_VALUE_EVENTS_BT",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false),
                    AMOUNT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHANGE_VALUE_EVENTS_BT", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_CHANGE_VALUE_EVENTS_BT_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "COMBAT_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false),
                    CREATURE_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMBAT_EVENTS", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_COMBAT_EVENTS_CREATURES_CREATURE_ID",
                        column: x => x.CREATURE_ID,
                        principalTable: "CREATURES",
                        principalColumn: "CREATURE_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_COMBAT_EVENTS_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DROP_ALL_WEAPONS_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DROP_ALL_WEAPONS_EVENTS", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_DROP_ALL_WEAPONS_EVENTS_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DROP_WEAPON_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DROP_WEAPON_EVENTS", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_DROP_WEAPON_EVENTS_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ITEM_EVENTS_BT",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false),
                    ITEM_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEM_EVENTS_BT", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_ITEM_EVENTS_BT_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ITEM_EVENTS_BT_ITEMS_ST_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "ITEMS_ST",
                        principalColumn: "ITEM_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MISSION_ACCOMPLISHED_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MISSION_ACCOMPLISHED_EVENTS", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_MISSION_ACCOMPLISHED_EVENTS_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MISSION_FAILED_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MISSION_FAILED_EVENTS", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_MISSION_FAILED_EVENTS_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "STORY_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false),
                    TITLE = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DESCRIPTION = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IMAGE_URL = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STORY_EVENTS", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_STORY_EVENTS_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DEFAULT_OUTCOMES",
                columns: table => new
                {
                    OUTCOME_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DEFAULT_OUTCOMES", x => x.OUTCOME_ID);
                    table.ForeignKey(
                        name: "FK_DEFAULT_OUTCOMES_OUTCOMES_BT_OUTCOME_ID",
                        column: x => x.OUTCOME_ID,
                        principalTable: "OUTCOMES_BT",
                        principalColumn: "OUTCOME_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GOLD_OUTCOMES",
                columns: table => new
                {
                    OUTCOME_ID = table.Column<int>(type: "int", nullable: false),
                    AMOUNT = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GOLD_OUTCOMES", x => x.OUTCOME_ID);
                    table.ForeignKey(
                        name: "FK_GOLD_OUTCOMES_OUTCOMES_BT_OUTCOME_ID",
                        column: x => x.OUTCOME_ID,
                        principalTable: "OUTCOMES_BT",
                        principalColumn: "OUTCOME_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ITEM_OUTCOMES",
                columns: table => new
                {
                    OUTCOME_ID = table.Column<int>(type: "int", nullable: false),
                    ITEM_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITEM_OUTCOMES", x => x.OUTCOME_ID);
                    table.ForeignKey(
                        name: "FK_ITEM_OUTCOMES_ITEMS_ST_ITEM_ID",
                        column: x => x.ITEM_ID,
                        principalTable: "ITEMS_ST",
                        principalColumn: "ITEM_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ITEM_OUTCOMES_OUTCOMES_BT_OUTCOME_ID",
                        column: x => x.OUTCOME_ID,
                        principalTable: "OUTCOMES_BT",
                        principalColumn: "OUTCOME_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MISSION_FAILED_OUTCOMES",
                columns: table => new
                {
                    OUTCOME_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MISSION_FAILED_OUTCOMES", x => x.OUTCOME_ID);
                    table.ForeignKey(
                        name: "FK_MISSION_FAILED_OUTCOMES_OUTCOMES_BT_OUTCOME_ID",
                        column: x => x.OUTCOME_ID,
                        principalTable: "OUTCOMES_BT",
                        principalColumn: "OUTCOME_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RANDOM_OUTCOMES",
                columns: table => new
                {
                    OUTCOME_ID = table.Column<int>(type: "int", nullable: false),
                    MIN = table.Column<int>(type: "int", nullable: false),
                    MAX = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RANDOM_OUTCOMES", x => x.OUTCOME_ID);
                    table.ForeignKey(
                        name: "FK_RANDOM_OUTCOMES_OUTCOMES_BT_OUTCOME_ID",
                        column: x => x.OUTCOME_ID,
                        principalTable: "OUTCOMES_BT",
                        principalColumn: "OUTCOME_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "COMBAT_SKILL_CHANGE_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMBAT_SKILL_CHANGE_EVENTS", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_COMBAT_SKILL_CHANGE_EVENTS_CHANGE_VALUE_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "CHANGE_VALUE_EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "COMBAT_SKILL_TEMPORARY_CHANGE_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMBAT_SKILL_TEMPORARY_CHANGE_EVENTS", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_COMBAT_SKILL_TEMPORARY_CHANGE_EVENTS_CHANGE_VALUE_EVENTS_BT_~",
                        column: x => x.EVENT_ID,
                        principalTable: "CHANGE_VALUE_EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ENDURANCE_CHANGE_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENDURANCE_CHANGE_EVENTS", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_ENDURANCE_CHANGE_EVENTS_CHANGE_VALUE_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "CHANGE_VALUE_EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GOLD_AMOUNT_CHANGE_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GOLD_AMOUNT_CHANGE_EVENTS", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_GOLD_AMOUNT_CHANGE_EVENTS_CHANGE_VALUE_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "CHANGE_VALUE_EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RATION_AMOUNT_CHANGE_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RATION_AMOUNT_CHANGE_EVENTS", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_RATION_AMOUNT_CHANGE_EVENTS_CHANGE_VALUE_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "CHANGE_VALUE_EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DROP_BACKPACK_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DROP_BACKPACK_EVENTS", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_DROP_BACKPACK_EVENTS_ITEM_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "ITEM_EVENTS_BT",
                        principalColumn: "EVENT_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DROP_ITEM_EVENTS",
                columns: table => new
                {
                    EVENT_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DROP_ITEM_EVENTS", x => x.EVENT_ID);
                    table.ForeignKey(
                        name: "FK_DROP_ITEM_EVENTS_ITEM_EVENTS_BT_EVENT_ID",
                        column: x => x.EVENT_ID,
                        principalTable: "ITEM_EVENTS_BT",
                        principalColumn: "EVENT_ID",
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
                name: "IX_ABILITY_HAS_EFFECTS_JT_EFFECT_ID",
                table: "ABILITY_HAS_EFFECTS_JT",
                column: "EFFECT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ABILITY_OUTCOMES_ABILITY_TYPE",
                table: "ABILITY_OUTCOMES",
                column: "ABILITY_TYPE");

            migrationBuilder.CreateIndex(
                name: "IX_BOOK_HAS_AUTHORS_JT_AUTHOR_ID",
                table: "BOOK_HAS_AUTHORS_JT",
                column: "AUTHOR_ID");

            migrationBuilder.CreateIndex(
                name: "IX_COMBAT_EVENTS_CREATURE_ID",
                table: "COMBAT_EVENTS",
                column: "CREATURE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CREATURE_HAS_ABILITIES_JT_ABILITY_TYPE",
                table: "CREATURE_HAS_ABILITIES_JT",
                column: "ABILITY_TYPE");

            migrationBuilder.CreateIndex(
                name: "IX_EVENTS_BT_SECTION_ID",
                table: "EVENTS_BT",
                column: "SECTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_HERO_HAS_ABILITIES_JT_ABILITY_TYPE",
                table: "HERO_HAS_ABILITIES_JT",
                column: "ABILITY_TYPE");

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
                column: "SESSION_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IMAGE_DECORATORS_SECTION_ID",
                table: "IMAGE_DECORATORS",
                column: "SECTION_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_INVENTORY_HAS_ITEMS_JT_ITEM_ID",
                table: "INVENTORY_HAS_ITEMS_JT",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ITEM_EVENTS_BT_ITEM_ID",
                table: "ITEM_EVENTS_BT",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ITEM_HAS_EFFECTS_JT_EFFECT_ID",
                table: "ITEM_HAS_EFFECTS_JT",
                column: "EFFECT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ITEM_OUTCOMES_ITEM_ID",
                table: "ITEM_OUTCOMES",
                column: "ITEM_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OUTCOMES_BT_ROOT_SECTION_ID",
                table: "OUTCOMES_BT",
                column: "ROOT_SECTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_OUTCOMES_BT_SECTION_ID",
                table: "OUTCOMES_BT",
                column: "SECTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_REGIONS_BT_AREA_ID",
                table: "REGIONS_BT",
                column: "AREA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SB_HAS_SECTIONS_JT_SECTION_ID",
                table: "SB_HAS_SECTIONS_JT",
                column: "SECTION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SECTIONS_BT_BOOK_ID",
                table: "SECTIONS_BT",
                column: "BOOK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SESSION_HAS_BOOKS_JT_BOOK_ID",
                table: "SESSION_HAS_BOOKS_JT",
                column: "BOOK_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SESSIONS_USER_ID",
                table: "SESSIONS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_STORY_SECTIONS_REGION_ID",
                table: "STORY_SECTIONS",
                column: "REGION_ID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ABILITY_OUTCOMES_OUTCOMES_BT_OUTCOME_ID",
                table: "ABILITY_OUTCOMES",
                column: "OUTCOME_ID",
                principalTable: "OUTCOMES_BT",
                principalColumn: "OUTCOME_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ACQUIRE_ITEM_EVENTS_ITEM_EVENTS_BT_EVENT_ID",
                table: "ACQUIRE_ITEM_EVENTS",
                column: "EVENT_ID",
                principalTable: "ITEM_EVENTS_BT",
                principalColumn: "EVENT_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AREAS_REGIONS_BT_REGION_ID",
                table: "AREAS",
                column: "REGION_ID",
                principalTable: "REGIONS_BT",
                principalColumn: "REGION_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AREAS_REGIONS_BT_REGION_ID",
                table: "AREAS");

            migrationBuilder.DropTable(
                name: "ABILITY_HAS_EFFECTS_JT");

            migrationBuilder.DropTable(
                name: "ABILITY_OUTCOMES");

            migrationBuilder.DropTable(
                name: "ACQUIRE_ITEM_EVENTS");

            migrationBuilder.DropTable(
                name: "BOOK_HAS_AUTHORS_JT");

            migrationBuilder.DropTable(
                name: "COMBAT_EVENTS");

            migrationBuilder.DropTable(
                name: "COMBAT_SKILL_CHANGE_EFFECTS");

            migrationBuilder.DropTable(
                name: "COMBAT_SKILL_CHANGE_EVENTS");

            migrationBuilder.DropTable(
                name: "COMBAT_SKILL_TEMPORARY_CHANGE_EVENTS");

            migrationBuilder.DropTable(
                name: "CREATURE_HAS_ABILITIES_JT");

            migrationBuilder.DropTable(
                name: "DEFAULT_OUTCOMES");

            migrationBuilder.DropTable(
                name: "DROP_ALL_WEAPONS_EVENTS");

            migrationBuilder.DropTable(
                name: "DROP_BACKPACK_EVENTS");

            migrationBuilder.DropTable(
                name: "DROP_ITEM_EVENTS");

            migrationBuilder.DropTable(
                name: "DROP_WEAPON_EVENTS");

            migrationBuilder.DropTable(
                name: "ENDURANCE_CHANGE_EFFECTS");

            migrationBuilder.DropTable(
                name: "ENDURANCE_CHANGE_EVENTS");

            migrationBuilder.DropTable(
                name: "GOLD_AMOUNT_CHANGE_EVENTS");

            migrationBuilder.DropTable(
                name: "GOLD_OUTCOMES");

            migrationBuilder.DropTable(
                name: "HERO_HAS_ABILITIES_JT");

            migrationBuilder.DropTable(
                name: "IMAGE_DECORATORS");

            migrationBuilder.DropTable(
                name: "INVENTORY_HAS_ITEMS_JT");

            migrationBuilder.DropTable(
                name: "ITEM_HAS_EFFECTS_JT");

            migrationBuilder.DropTable(
                name: "ITEM_OUTCOMES");

            migrationBuilder.DropTable(
                name: "MISSION_ACCOMPLISHED_EVENTS");

            migrationBuilder.DropTable(
                name: "MISSION_FAILED_EVENTS");

            migrationBuilder.DropTable(
                name: "MISSION_FAILED_OUTCOMES");

            migrationBuilder.DropTable(
                name: "POINTS_OF_INTEREST");

            migrationBuilder.DropTable(
                name: "RANDOM_OUTCOMES");

            migrationBuilder.DropTable(
                name: "RATION_AMOUNT_CHANGE_EVENTS");

            migrationBuilder.DropTable(
                name: "RULE_SECTIONS");

            migrationBuilder.DropTable(
                name: "SB_HAS_SECTIONS_JT");

            migrationBuilder.DropTable(
                name: "STORY_EVENTS");

            migrationBuilder.DropTable(
                name: "USER_HAS_ROLES_JT");

            migrationBuilder.DropTable(
                name: "AUTHORS");

            migrationBuilder.DropTable(
                name: "CREATURES");

            migrationBuilder.DropTable(
                name: "ITEM_EVENTS_BT");

            migrationBuilder.DropTable(
                name: "VALUE_CHANGE_EFFECTS_BT");

            migrationBuilder.DropTable(
                name: "ABILITIES");

            migrationBuilder.DropTable(
                name: "HEROES");

            migrationBuilder.DropTable(
                name: "OUTCOMES_BT");

            migrationBuilder.DropTable(
                name: "CHANGE_VALUE_EVENTS_BT");

            migrationBuilder.DropTable(
                name: "SESSION_HAS_BOOKS_JT");

            migrationBuilder.DropTable(
                name: "USER_ROLES");

            migrationBuilder.DropTable(
                name: "ITEMS_ST");

            migrationBuilder.DropTable(
                name: "EFFECTS_BT");

            migrationBuilder.DropTable(
                name: "HERO_OWNERSHIPS");

            migrationBuilder.DropTable(
                name: "INVENTORIES");

            migrationBuilder.DropTable(
                name: "PLAYER_LEVELS");

            migrationBuilder.DropTable(
                name: "EVENTS_BT");

            migrationBuilder.DropTable(
                name: "SESSIONS");

            migrationBuilder.DropTable(
                name: "STORY_SECTIONS");

            migrationBuilder.DropTable(
                name: "USERS");

            migrationBuilder.DropTable(
                name: "SECTIONS_BT");

            migrationBuilder.DropTable(
                name: "BOOKS");

            migrationBuilder.DropTable(
                name: "REGIONS_BT");

            migrationBuilder.DropTable(
                name: "AREAS");
        }
    }
}
