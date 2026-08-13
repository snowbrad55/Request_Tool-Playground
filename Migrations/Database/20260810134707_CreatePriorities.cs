using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TyphoonTaskingTool.Migrations.Database
{
    /// <inheritdoc />
    public partial class CreatePriorities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriorityId",
                table: "RequestUpdates",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LOOKUP_Priority",
                columns: table => new
                {
                    Priority_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Priority_Level = table.Column<int>(type: "integer", nullable: false),
                    Priority_Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Priority_Description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Priority_Level_Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOOKUP_Priority", x => x.Priority_Id);
                });

            migrationBuilder.InsertData(
                table: "LOOKUP_Priority",
                columns: new[] { "Priority_Id", "Priority_Description", "Priority_Level", "Priority_Level_Description", "Priority_Name" },
                values: new object[,]
                {
                    { 1, "Task triaged as being High/High impact with High/Medium urgency", 1, "24 hour response time, 48 hour resolution time", "Critical" },
                    { 2, "Task triaged as being High/Medium impact with Medium/High urgency", 2, "48 hour response time, 5 day resolution time", "High" },
                    { 3, "Task triaged as being Low/Medium impact with High/Medium urgency", 3, "5 day response time, 10 day resolution time", "Medium" },
                    { 4, "Task triaged as being Low impact with Medium urgency", 4, "10 day response time, 20 day resolution time", "Low" },
                    { 5, "Routine enhancement request.", 5, "Enhancement requests will be reviewed and prioritized based on business needs.", "Enhancement" }
                });

            migrationBuilder.InsertData(
                table: "LOOKUP_Unit",
                columns: new[] { "Unit_Id", "Unit_NameLong", "Unit_NameShort" },
                values: new object[,]
                {
                    { 5001, "Number 3 (Fighter) Squadron", "3(F) Sqn" },
                    { 5003, "Number 11 (Fighter) Squadron", "XI (F) Sqn" },
                    { 5006, "Number 12 Squadron", "12 Sqn" },
                    { 5009, "Number 29 Squadron", "29 Sqn" },
                    { 5012, "Number 41 (Test and Evaluation) Squadron", "41 (TES) Sqn" },
                    { 5015, "Typhoon National Support Centre", "Ty NSC" },
                    { 5018, "Typhoon Mission Support Centre", "Ty MSC" },
                    { 5021, "Typhoon CAMO", "Ty CAMO" },
                    { 5024, "Air & Space Warfare Centre", "ASWC" },
                    { 5027, "Typhoon Force Headquarters", "Ty FHQ" },
                    { 5030, "Any Other External Organisation", "Others" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestUpdates_PriorityId",
                table: "RequestUpdates",
                column: "PriorityId");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestUpdates_LOOKUP_Priority_PriorityId",
                table: "RequestUpdates",
                column: "PriorityId",
                principalTable: "LOOKUP_Priority",
                principalColumn: "Priority_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestUpdates_LOOKUP_Priority_PriorityId",
                table: "RequestUpdates");

            migrationBuilder.DropTable(
                name: "LOOKUP_Priority");

            migrationBuilder.DropIndex(
                name: "IX_RequestUpdates_PriorityId",
                table: "RequestUpdates");

            migrationBuilder.DeleteData(
                table: "LOOKUP_Unit",
                keyColumn: "Unit_Id",
                keyValue: 5001);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Unit",
                keyColumn: "Unit_Id",
                keyValue: 5003);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Unit",
                keyColumn: "Unit_Id",
                keyValue: 5006);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Unit",
                keyColumn: "Unit_Id",
                keyValue: 5009);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Unit",
                keyColumn: "Unit_Id",
                keyValue: 5012);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Unit",
                keyColumn: "Unit_Id",
                keyValue: 5015);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Unit",
                keyColumn: "Unit_Id",
                keyValue: 5018);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Unit",
                keyColumn: "Unit_Id",
                keyValue: 5021);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Unit",
                keyColumn: "Unit_Id",
                keyValue: 5024);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Unit",
                keyColumn: "Unit_Id",
                keyValue: 5027);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Unit",
                keyColumn: "Unit_Id",
                keyValue: 5030);

            migrationBuilder.DropColumn(
                name: "PriorityId",
                table: "RequestUpdates");
        }
    }
}
