using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TyphoonTaskingTool.Migrations.Database
{
    /// <inheritdoc />
    public partial class initial_Db_Commit_postgresql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("CREATE EXTENSION IF NOT EXISTS \"pgcrypto\";");
            migrationBuilder.CreateTable(
                name: "LOOKUP_Rank",
                columns: table => new
                {
                    Rank_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rank_NameLong = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Rank_NameShort = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Rank_NATOEquiv = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOOKUP_Rank", x => x.Rank_Id);
                });

            migrationBuilder.CreateTable(
                name: "LOOKUP_Status",
                columns: table => new
                {
                    Status_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status_Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Status_Description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOOKUP_Status", x => x.Status_Id);
                });

            migrationBuilder.CreateTable(
                name: "LOOKUP_Team",
                columns: table => new
                {
                    Team_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Team_NameLong = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Team_NameShort = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOOKUP_Team", x => x.Team_Id);
                });

            migrationBuilder.CreateTable(
                name: "LOOKUP_Unit",
                columns: table => new
                {
                    Unit_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Unit_NameLong = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Unit_NameShort = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOOKUP_Unit", x => x.Unit_Id);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Request_TaskId = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Request_ShortId = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    Request_Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Rank_Id = table.Column<int>(type: "integer", nullable: true),
                    Request_FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Request_LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Request_EmailAdd = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Request_ContactPhone = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    Unit_Id = table.Column<int>(type: "integer", nullable: true),
                    Team_Id = table.Column<int>(type: "integer", nullable: true),
                    Request_Title = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Request_TaskDescription = table.Column<string>(type: "text", nullable: true),
                    Status_Id = table.Column<int>(type: "integer", nullable: true),
                    Request_Archive = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Request_TaskId);
                    table.ForeignKey(
                        name: "FK_Request_Rank",
                        column: x => x.Rank_Id,
                        principalTable: "LOOKUP_Rank",
                        principalColumn: "Rank_Id");
                    table.ForeignKey(
                        name: "FK_Request_Status",
                        column: x => x.Status_Id,
                        principalTable: "LOOKUP_Status",
                        principalColumn: "Status_Id");
                    table.ForeignKey(
                        name: "FK_Request_Team",
                        column: x => x.Team_Id,
                        principalTable: "LOOKUP_Team",
                        principalColumn: "Team_Id");
                    table.ForeignKey(
                        name: "FK_Request_Unit",
                        column: x => x.Unit_Id,
                        principalTable: "LOOKUP_Unit",
                        principalColumn: "Unit_Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestUpdates",
                columns: table => new
                {
                    Update_Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Request_TaskId = table.Column<Guid>(type: "uuid", nullable: false),
                    Update_TimeStamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Update_Description = table.Column<string>(type: "text", nullable: true),
                    Update_By = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Status_Id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestUpdates", x => x.Update_Id);
                    table.ForeignKey(
                        name: "FK_UpdateRequest",
                        column: x => x.Request_TaskId,
                        principalTable: "Requests",
                        principalColumn: "Request_TaskId");
                    table.ForeignKey(
                        name: "FK_UpdateStatus",
                        column: x => x.Status_Id,
                        principalTable: "LOOKUP_Status",
                        principalColumn: "Status_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_Rank_Id",
                table: "Requests",
                column: "Rank_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_Status_Id",
                table: "Requests",
                column: "Status_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_Team_Id",
                table: "Requests",
                column: "Team_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_Unit_Id",
                table: "Requests",
                column: "Unit_Id");

            migrationBuilder.CreateIndex(
                name: "IX_RequestUpdates_Request_TaskId",
                table: "RequestUpdates",
                column: "Request_TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestUpdates_Status_Id",
                table: "RequestUpdates",
                column: "Status_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP EXTENSION IF NOT EXISTS \"pgcrypto\";");

            migrationBuilder.DropTable(
                name: "RequestUpdates");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "LOOKUP_Rank");

            migrationBuilder.DropTable(
                name: "LOOKUP_Status");

            migrationBuilder.DropTable(
                name: "LOOKUP_Team");

            migrationBuilder.DropTable(
                name: "LOOKUP_Unit");
        }
    }
}
