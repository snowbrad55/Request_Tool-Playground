using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TyphoonTaskingTool.Migrations.Database
{
    /// <inheritdoc />
    public partial class general_update_for_requests_AL1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Assignment_UserId",
                table: "RequestUpdates",
                type: "character varying(450)",
                maxLength: 450,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Team_Id",
                table: "RequestUpdates",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LOOKUP_Stores",
                columns: table => new
                {
                    Store_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Store_Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Store_Description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Image_Url = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOOKUP_Stores", x => x.Store_Id);
                });

            migrationBuilder.InsertData(
                table: "LOOKUP_Stores",
                columns: new[] { "Store_Id", "Image_Url", "Store_Description", "Store_Name" },
                values: new object[,]
                {
                    { 101, "images/A2A/AMRAAM_120_B5.png", "Description for Store A", "AMRAAM 120 B5" },
                    { 102, "images/A2A/AMRAAM_120-D.png", "Description for Store A", "AMRAAM 120 D" },
                    { 103, "images/A2A/AMRAAM_120M-C5.png", "Description for Store A", "AMRAAM 120M C5" },
                    { 104, "images/A2A/AMRAAM_120M-C5_AAVI.png", "Description for Store A", "AMRAAM 120M C5 AAVI" },
                    { 105, "images/A2A/AMRAAM_OM.png", "Description for Store A", "AMRAAM 120 OM" },
                    { 106, "images/A2A/ASRAAM_TOM.png", "Description for Store A", "ASRAAM TOM" },
                    { 201, "images/A2A/BS2_STN_3_Empty.png", "Description for Store A", "BS STN 3 Empty" },
                    { 202, "images/A2A/BS2_STN_4_Empty.png", "Description for Store A", "BS STN 4 Empty" },
                    { 203, "images/A2A/BS2_EDGM.png", "Description for Store A", "BS 2 EDGM" },
                    { 204, "images/A2A/BS2_OM.png", "Description for Store A", "BS 2 OM" },
                    { 205, "images/A2A/BS2_TOM.png", "Description for Store A", "BS 2 TOM" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RequestUpdates_Assignment_UserId",
                table: "RequestUpdates",
                column: "Assignment_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestUpdates_Team_Id",
                table: "RequestUpdates",
                column: "Team_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UpdateAssignedUser",
                table: "RequestUpdates",
                column: "Assignment_UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UpdateTeam",
                table: "RequestUpdates",
                column: "Team_Id",
                principalTable: "LOOKUP_Team",
                principalColumn: "Team_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UpdateAssignedUser",
                table: "RequestUpdates");

            migrationBuilder.DropForeignKey(
                name: "FK_UpdateTeam",
                table: "RequestUpdates");

            migrationBuilder.DropTable(
                name: "LOOKUP_Stores");

            migrationBuilder.DropIndex(
                name: "IX_RequestUpdates_Assignment_UserId",
                table: "RequestUpdates");

            migrationBuilder.DropIndex(
                name: "IX_RequestUpdates_Team_Id",
                table: "RequestUpdates");

            migrationBuilder.DropColumn(
                name: "Assignment_UserId",
                table: "RequestUpdates");

            migrationBuilder.DropColumn(
                name: "Team_Id",
                table: "RequestUpdates");
        }
    }
}
