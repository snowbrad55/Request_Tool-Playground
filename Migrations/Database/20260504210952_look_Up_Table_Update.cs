using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TyphoonTaskingTool.Migrations.Database
{
    /// <inheritdoc />
    public partial class look_Up_Table_Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LOOKUP_TrafficLight",
                columns: table => new
                {
                    TrafficLightID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrafficLightName = table.Column<string>(type: "text", nullable: true),
                    TrafficLightDescription = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOOKUP_TrafficLight", x => x.TrafficLightID);
                });

            migrationBuilder.CreateTable(
                name: "RigRequests",
                columns: table => new
                {
                    Rig_Request_Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "gen_random_uuid()"),
                    Rig_Request_Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Rig_Request_Title = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    rigRequestStartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    rigRequestEndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    rigRequestDescription = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    rigRequestAddtionalRig = table.Column<string>(type: "text", nullable: true),
                    rigRequestAdditionalMD = table.Column<string>(type: "text", nullable: true),
                    Status_Id = table.Column<int>(type: "integer", nullable: true),
                    rigRequestArchive = table.Column<bool>(type: "boolean", nullable: true),
                    Rig_Request_Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    rigRequestRankId = table.Column<int>(type: "integer", nullable: true),
                    rigCcbCompelte = table.Column<bool>(type: "boolean", nullable: false),
                    rigCcbRefernce = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RigRequests", x => x.Rig_Request_Id);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalSystems",
                columns: table => new
                {
                    rigRequestId = table.Column<Guid>(type: "uuid", nullable: false),
                    requestrigRequestId = table.Column<Guid>(type: "uuid", nullable: false),
                    additionalSystem_Mids_Tiger = table.Column<string>(type: "text", nullable: true),
                    additionalSystem_Mids_Tiger_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    additionalSystem_Pasis = table.Column<string>(type: "text", nullable: true),
                    additionalSystem_Pasis_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    additionalSystem_Meteor_Em = table.Column<string>(type: "text", nullable: true),
                    additionalSystem_Meteor_Em_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    additionalSystem_Asraam_Em = table.Column<string>(type: "text", nullable: true),
                    additionalSystem_Asraam_Em_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    additionalSystem_SS_Em = table.Column<string>(type: "text", nullable: true),
                    additionalSystem_SS_Em_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    additionalSystem_B2_Em = table.Column<string>(type: "text", nullable: true),
                    additionalSystem_B2_Em_TrafficLightId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalSystems", x => x.rigRequestId);
                    table.ForeignKey(
                        name: "FK_AdditionalSystems_RigRequests_requestrigRequestId",
                        column: x => x.requestrigRequestId,
                        principalTable: "RigRequests",
                        principalColumn: "Rig_Request_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CriticalLRIs",
                columns: table => new
                {
                    rigRequestId = table.Column<Guid>(type: "uuid", nullable: false),
                    requestrigRequestId = table.Column<Guid>(type: "uuid", nullable: false),
                    criticalLRI_Mids = table.Column<string>(type: "text", nullable: true),
                    criticalLRI_Mids_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    criticalLRI_Radar = table.Column<string>(type: "text", nullable: true),
                    criticalLRI_Radar_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    criticalLRI_Gps = table.Column<string>(type: "text", nullable: true),
                    criticalLRI_Gps_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    criticalLRI_Other = table.Column<string>(type: "text", nullable: true),
                    criticalLRI_Other_TrafficLightId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriticalLRIs", x => x.rigRequestId);
                    table.ForeignKey(
                        name: "FK_CriticalLRIs_RigRequests_requestrigRequestId",
                        column: x => x.requestrigRequestId,
                        principalTable: "RigRequests",
                        principalColumn: "Rig_Request_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataRecording",
                columns: table => new
                {
                    rigRequestId = table.Column<Guid>(type: "uuid", nullable: false),
                    requestrigRequestId = table.Column<Guid>(type: "uuid", nullable: false),
                    recording_1 = table.Column<string>(type: "text", nullable: true),
                    recording_1_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    recording_2 = table.Column<string>(type: "text", nullable: true),
                    recording_2_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    recording_3 = table.Column<string>(type: "text", nullable: true),
                    recording_3_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    recording_4 = table.Column<string>(type: "text", nullable: true),
                    recording_4_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    recording_5 = table.Column<string>(type: "text", nullable: true),
                    recording_5_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    recording_6 = table.Column<string>(type: "text", nullable: true),
                    recording_6_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    mhdd = table.Column<string>(type: "text", nullable: true),
                    mhdd_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    additionalRecording = table.Column<string>(type: "text", nullable: true),
                    additionalRecording_TrafficLightId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataRecording", x => x.rigRequestId);
                    table.ForeignKey(
                        name: "FK_DataRecording_RigRequests_requestrigRequestId",
                        column: x => x.requestrigRequestId,
                        principalTable: "RigRequests",
                        principalColumn: "Rig_Request_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MissionPlanning",
                columns: table => new
                {
                    rigRequestId = table.Column<Guid>(type: "uuid", nullable: false),
                    requestrigRequestId = table.Column<Guid>(type: "uuid", nullable: false),
                    missionPlanning_MissionType = table.Column<string>(type: "text", nullable: true),
                    missionPlanning_MissionType_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    missionPlanning_Maps = table.Column<string>(type: "text", nullable: true),
                    missionPlanning_Maps_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    missionPlanning_L16_Ntwk = table.Column<string>(type: "text", nullable: true),
                    missionPlanning_L16_Ntwk_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    missionPlanning_L16_IDS = table.Column<string>(type: "text", nullable: true),
                    missionPlanning_L16_IDS_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    missionPlanning_Ss_Mission_File = table.Column<string>(type: "text", nullable: true),
                    missionPlanning_Ss_Mission_File_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    MissionPlanning_Geo_Location = table.Column<string>(type: "text", nullable: true),
                    MissionPlanning_Geo_Location_TrafficLightId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionPlanning", x => x.rigRequestId);
                    table.ForeignKey(
                        name: "FK_MissionPlanning_RigRequests_requestrigRequestId",
                        column: x => x.requestrigRequestId,
                        principalTable: "RigRequests",
                        principalColumn: "Rig_Request_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RigSetup",
                columns: table => new
                {
                    rigRequestId = table.Column<Guid>(type: "uuid", nullable: false),
                    requestrigRequestId = table.Column<Guid>(type: "uuid", nullable: false),
                    rigSetup_Patching = table.Column<string>(type: "text", nullable: true),
                    rigSetup_Patching_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    rigSetup_Avionic_Std = table.Column<string>(type: "text", nullable: true),
                    rigSetup_Avionic_Std_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    rigSetup_Radar_Software = table.Column<string>(type: "text", nullable: true),
                    rigSetup_Radar_Software_TrafficLightId = table.Column<int>(type: "integer", nullable: true),
                    rigSetup_Geo_Location = table.Column<string>(type: "text", nullable: true),
                    rigSetup_Geo_Location_TrafficLightId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RigSetup", x => x.rigRequestId);
                    table.ForeignKey(
                        name: "FK_RigSetup_RigRequests_requestrigRequestId",
                        column: x => x.requestrigRequestId,
                        principalTable: "RigRequests",
                        principalColumn: "Rig_Request_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LOOKUP_Rank",
                columns: new[] { "Rank_Id", "Rank_NameLong", "Rank_NameShort", "Rank_NATOEquiv" },
                values: new object[,]
                {
                    { 1, "Air Recruit", "AR", "OR-1" },
                    { 4, "Air Specialist 2", "AS2", "OR-2" },
                    { 7, "Air Specialist 1", "AS1", "OR-2" },
                    { 10, "Air Specialist 1 (Technician)", "AS1(T)", "OR-2" },
                    { 13, "Lance Corporal", "LCpl", "OR-3" },
                    { 16, "Corporal", "Cpl", "OR-4" },
                    { 19, "Sergeant", "Sgt", "OR-6" },
                    { 22, "Chief Technician", "CT", "OR-7" },
                    { 25, "Flight Sergeant", "FS", "OR-7" },
                    { 28, "Warrant Officer / Master Aircrew", "WO/MAcr", "OR-9" },
                    { 41, "Pilot Officer", "PO", "OF-1" },
                    { 44, "Flying Officer", "FO", "OF-1" },
                    { 47, "Flight Lieutenant", "Flt Lt", "OF-2" },
                    { 50, "Squadron Leader", "Sqn Ldr", "OF-3" },
                    { 53, "Wing Commander", "Wg Cdr", "OF-4" },
                    { 56, "Group Captain", "Gp Capt", "OF-5" },
                    { 59, "Air Commodore", "Air Cmdre", "OF-6" },
                    { 62, "Air Vice Marshall", "AVM", "OF-7" },
                    { 65, "Air Marshall", "AM", "OF-8" },
                    { 68, "Air Chief Marshall", "ACM", "OF-9" },
                    { 71, "Marshall of the Royal Air Force", "MRAF", "OF-10" }
                });

            migrationBuilder.InsertData(
                table: "LOOKUP_Status",
                columns: new[] { "Status_Id", "Status_Description", "Status_Name" },
                values: new object[,]
                {
                    { 1, "The task has been submitted .", "Submitted" },
                    { 2, "The task is active and ongoing.", "Active" },
                    { 3, "The task has been completed successfully.", "Completed" },
                    { 4, "The task is temporarily paused and awaiting further action.", "On Hold" },
                    { 5, "The task has been cancelled and will not be completed.", "Cancelled" },
                    { 6, "The task is currently in progress and being worked on.", "In Progress" }
                });

            migrationBuilder.InsertData(
                table: "LOOKUP_Team",
                columns: new[] { "Team_Id", "Team_NameLong", "Team_NameShort" },
                values: new object[,]
                {
                    { 1001, "Information Exploitation and Technology Support", "IxTS" },
                    { 1005, "Data Management", "DM" },
                    { 1009, "Typhoon Mission Data Team", "TMDT" },
                    { 1013, "Industry Specialists", "Ind Spec" },
                    { 1017, "Mission Data Analysis Team", "MDAT" },
                    { 1021, "Attack and Identification", "A and I" },
                    { 1026, "Management", "Mgmnt" }
                });

            migrationBuilder.InsertData(
                table: "LOOKUP_TrafficLight",
                columns: new[] { "TrafficLightID", "TrafficLightDescription", "TrafficLightName" },
                values: new object[,]
                {
                    { 1, "Not Required", "BLANK" },
                    { 2, "Desirable", "YELLOW" },
                    { 3, "Highly Desirable", "AMBER" },
                    { 4, "Essential", "RED" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalSystems_requestrigRequestId",
                table: "AdditionalSystems",
                column: "requestrigRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_CriticalLRIs_requestrigRequestId",
                table: "CriticalLRIs",
                column: "requestrigRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_DataRecording_requestrigRequestId",
                table: "DataRecording",
                column: "requestrigRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_MissionPlanning_requestrigRequestId",
                table: "MissionPlanning",
                column: "requestrigRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_RigSetup_requestrigRequestId",
                table: "RigSetup",
                column: "requestrigRequestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalSystems");

            migrationBuilder.DropTable(
                name: "CriticalLRIs");

            migrationBuilder.DropTable(
                name: "DataRecording");

            migrationBuilder.DropTable(
                name: "LOOKUP_TrafficLight");

            migrationBuilder.DropTable(
                name: "MissionPlanning");

            migrationBuilder.DropTable(
                name: "RigSetup");

            migrationBuilder.DropTable(
                name: "RigRequests");

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Rank",
                keyColumn: "Rank_Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Status",
                keyColumn: "Status_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Status",
                keyColumn: "Status_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Status",
                keyColumn: "Status_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Status",
                keyColumn: "Status_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Status",
                keyColumn: "Status_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Status",
                keyColumn: "Status_Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Team",
                keyColumn: "Team_Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Team",
                keyColumn: "Team_Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Team",
                keyColumn: "Team_Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Team",
                keyColumn: "Team_Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Team",
                keyColumn: "Team_Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Team",
                keyColumn: "Team_Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "LOOKUP_Team",
                keyColumn: "Team_Id",
                keyValue: 1026);
        }
    }
}
