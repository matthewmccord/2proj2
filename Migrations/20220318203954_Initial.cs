using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _2proj2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "slots",
                columns: table => new
                {
                    TimeID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_slots", x => x.TimeID);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    TimeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_responses_slots_TimeId",
                        column: x => x.TimeId,
                        principalTable: "slots",
                        principalColumn: "TimeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 1, true, new DateTime(2022, 4, 1, 8, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 66, true, new DateTime(2022, 4, 6, 8, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 65, true, new DateTime(2022, 4, 5, 20, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 64, true, new DateTime(2022, 4, 5, 19, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 63, true, new DateTime(2022, 4, 5, 18, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 62, true, new DateTime(2022, 4, 5, 17, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 61, true, new DateTime(2022, 4, 5, 16, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 60, true, new DateTime(2022, 4, 5, 15, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 59, true, new DateTime(2022, 4, 5, 14, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 58, true, new DateTime(2022, 4, 5, 13, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 57, true, new DateTime(2022, 4, 5, 12, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 56, true, new DateTime(2022, 4, 5, 11, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 55, true, new DateTime(2022, 4, 5, 10, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 54, true, new DateTime(2022, 4, 5, 9, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 53, true, new DateTime(2022, 4, 5, 8, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 52, true, new DateTime(2022, 4, 4, 20, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 51, true, new DateTime(2022, 4, 4, 19, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 50, true, new DateTime(2022, 4, 4, 18, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 49, true, new DateTime(2022, 4, 4, 17, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 48, true, new DateTime(2022, 4, 4, 16, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 67, true, new DateTime(2022, 4, 6, 9, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 47, true, new DateTime(2022, 4, 4, 15, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 68, true, new DateTime(2022, 4, 6, 10, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 70, true, new DateTime(2022, 4, 6, 12, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 89, true, new DateTime(2022, 4, 7, 18, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 88, true, new DateTime(2022, 4, 7, 17, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 87, true, new DateTime(2022, 4, 7, 16, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 86, true, new DateTime(2022, 4, 7, 15, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 85, true, new DateTime(2022, 4, 7, 14, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 84, true, new DateTime(2022, 4, 7, 13, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 83, true, new DateTime(2022, 4, 7, 12, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 82, true, new DateTime(2022, 4, 7, 11, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 81, true, new DateTime(2022, 4, 7, 10, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 80, true, new DateTime(2022, 4, 7, 9, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 79, true, new DateTime(2022, 4, 7, 8, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 78, true, new DateTime(2022, 4, 6, 20, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 77, true, new DateTime(2022, 4, 6, 19, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 76, true, new DateTime(2022, 4, 6, 18, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 75, true, new DateTime(2022, 4, 6, 17, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 74, true, new DateTime(2022, 4, 6, 16, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 73, true, new DateTime(2022, 4, 6, 15, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 72, true, new DateTime(2022, 4, 6, 14, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 71, true, new DateTime(2022, 4, 6, 13, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 69, true, new DateTime(2022, 4, 6, 11, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 90, true, new DateTime(2022, 4, 7, 19, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 46, true, new DateTime(2022, 4, 4, 14, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 44, true, new DateTime(2022, 4, 4, 12, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 20, true, new DateTime(2022, 4, 2, 14, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 19, true, new DateTime(2022, 4, 2, 13, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 18, true, new DateTime(2022, 4, 2, 12, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 17, true, new DateTime(2022, 4, 2, 11, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 16, true, new DateTime(2022, 4, 2, 10, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 15, true, new DateTime(2022, 4, 2, 9, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 14, true, new DateTime(2022, 4, 2, 8, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 13, true, new DateTime(2022, 4, 1, 20, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 12, true, new DateTime(2022, 4, 1, 19, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 11, true, new DateTime(2022, 4, 1, 18, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 10, true, new DateTime(2022, 4, 1, 17, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 9, true, new DateTime(2022, 4, 1, 16, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 8, true, new DateTime(2022, 4, 1, 15, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 7, true, new DateTime(2022, 4, 1, 14, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 6, true, new DateTime(2022, 4, 1, 13, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 5, true, new DateTime(2022, 4, 1, 12, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 4, true, new DateTime(2022, 4, 1, 11, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 3, true, new DateTime(2022, 4, 1, 10, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 2, true, new DateTime(2022, 4, 1, 9, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 21, true, new DateTime(2022, 4, 2, 15, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 45, true, new DateTime(2022, 4, 4, 13, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 22, true, new DateTime(2022, 4, 2, 16, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 24, true, new DateTime(2022, 4, 2, 18, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 43, true, new DateTime(2022, 4, 4, 11, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 42, true, new DateTime(2022, 4, 4, 10, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 41, true, new DateTime(2022, 4, 4, 9, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 40, true, new DateTime(2022, 4, 4, 8, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 4, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 39, true, new DateTime(2022, 4, 3, 20, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 38, true, new DateTime(2022, 4, 3, 19, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 37, true, new DateTime(2022, 4, 3, 18, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 36, true, new DateTime(2022, 4, 3, 17, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 35, true, new DateTime(2022, 4, 3, 16, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 34, true, new DateTime(2022, 4, 3, 15, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 33, true, new DateTime(2022, 4, 3, 14, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 32, true, new DateTime(2022, 4, 3, 13, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 31, true, new DateTime(2022, 4, 3, 12, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 30, true, new DateTime(2022, 4, 3, 11, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 29, true, new DateTime(2022, 4, 3, 10, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 28, true, new DateTime(2022, 4, 3, 9, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 27, true, new DateTime(2022, 4, 3, 8, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 26, true, new DateTime(2022, 4, 2, 20, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 25, true, new DateTime(2022, 4, 2, 19, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 23, true, new DateTime(2022, 4, 2, 17, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "slots",
                columns: new[] { "TimeID", "Available", "End", "Start" },
                values: new object[] { 91, true, new DateTime(2022, 4, 7, 20, 59, 59, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "GroupId", "Email", "GroupSize", "Name", "PhoneNumber", "TimeId" },
                values: new object[] { 2, "aberg21@gmail.com", 25, "Austin Berg", "123-456-7890", 1 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "GroupId", "Email", "GroupSize", "Name", "PhoneNumber", "TimeId" },
                values: new object[] { 3, "test@test.com", 6, "matt mccord", "123-456-7234", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_responses_TimeId",
                table: "responses",
                column: "TimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "slots");
        }
    }
}
