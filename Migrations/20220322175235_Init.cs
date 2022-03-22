using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _2proj2.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    GroupSize = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.GroupId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 1, "", new DateTime(2022, 4, 1, 8, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 66, "", new DateTime(2022, 4, 6, 8, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 65, "", new DateTime(2022, 4, 5, 20, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 5, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 64, "", new DateTime(2022, 4, 5, 19, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 5, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 63, "", new DateTime(2022, 4, 5, 18, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 5, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 62, "", new DateTime(2022, 4, 5, 17, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 5, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 61, "", new DateTime(2022, 4, 5, 16, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 60, "", new DateTime(2022, 4, 5, 15, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 5, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 59, "", new DateTime(2022, 4, 5, 14, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 58, "", new DateTime(2022, 4, 5, 13, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 5, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 57, "", new DateTime(2022, 4, 5, 12, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 5, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 56, "", new DateTime(2022, 4, 5, 11, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 5, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 55, "", new DateTime(2022, 4, 5, 10, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 54, "", new DateTime(2022, 4, 5, 9, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 5, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 53, "", new DateTime(2022, 4, 5, 8, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 52, "", new DateTime(2022, 4, 4, 20, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 4, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 51, "", new DateTime(2022, 4, 4, 19, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 4, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 50, "", new DateTime(2022, 4, 4, 18, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 4, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 49, "", new DateTime(2022, 4, 4, 17, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 4, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 48, "", new DateTime(2022, 4, 4, 16, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 4, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 67, "", new DateTime(2022, 4, 6, 9, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 47, "", new DateTime(2022, 4, 4, 15, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 4, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 68, "", new DateTime(2022, 4, 6, 10, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 70, "", new DateTime(2022, 4, 6, 12, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 6, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 89, "", new DateTime(2022, 4, 7, 18, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 7, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 88, "", new DateTime(2022, 4, 7, 17, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 7, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 87, "", new DateTime(2022, 4, 7, 16, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 7, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 86, "", new DateTime(2022, 4, 7, 15, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 7, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 85, "", new DateTime(2022, 4, 7, 14, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 7, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 84, "", new DateTime(2022, 4, 7, 13, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 7, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 83, "", new DateTime(2022, 4, 7, 12, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 82, "", new DateTime(2022, 4, 7, 11, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 7, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 81, "", new DateTime(2022, 4, 7, 10, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 80, "", new DateTime(2022, 4, 7, 9, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 79, "", new DateTime(2022, 4, 7, 8, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 78, "", new DateTime(2022, 4, 6, 20, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 6, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 77, "", new DateTime(2022, 4, 6, 19, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 6, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 76, "", new DateTime(2022, 4, 6, 18, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 6, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 75, "", new DateTime(2022, 4, 6, 17, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 6, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 74, "", new DateTime(2022, 4, 6, 16, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 6, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 73, "", new DateTime(2022, 4, 6, 15, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 6, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 72, "", new DateTime(2022, 4, 6, 14, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 6, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 71, "", new DateTime(2022, 4, 6, 13, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 6, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 69, "", new DateTime(2022, 4, 6, 11, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 90, "", new DateTime(2022, 4, 7, 19, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 7, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 46, "", new DateTime(2022, 4, 4, 14, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 4, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 44, "", new DateTime(2022, 4, 4, 12, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 4, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 20, "", new DateTime(2022, 4, 2, 14, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 2, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 19, "", new DateTime(2022, 4, 2, 13, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 2, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 18, "", new DateTime(2022, 4, 2, 12, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 2, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 17, "", new DateTime(2022, 4, 2, 11, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 2, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 16, "", new DateTime(2022, 4, 2, 10, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 2, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 15, "", new DateTime(2022, 4, 2, 9, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 14, "", new DateTime(2022, 4, 2, 8, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 13, "", new DateTime(2022, 4, 1, 20, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 1, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 12, "", new DateTime(2022, 4, 1, 19, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 1, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 11, "", new DateTime(2022, 4, 1, 18, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 10, "", new DateTime(2022, 4, 1, 17, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 9, "", new DateTime(2022, 4, 1, 16, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 8, "", new DateTime(2022, 4, 1, 15, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 7, "", new DateTime(2022, 4, 1, 14, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 6, "", new DateTime(2022, 4, 1, 13, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 1, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 5, "", new DateTime(2022, 4, 1, 12, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 4, "", new DateTime(2022, 4, 1, 11, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 3, "", new DateTime(2022, 4, 1, 10, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 2, "", new DateTime(2022, 4, 1, 9, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 21, "", new DateTime(2022, 4, 2, 15, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 2, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 45, "", new DateTime(2022, 4, 4, 13, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 4, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 22, "", new DateTime(2022, 4, 2, 16, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 24, "", new DateTime(2022, 4, 2, 18, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 2, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 43, "", new DateTime(2022, 4, 4, 11, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 4, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 42, "", new DateTime(2022, 4, 4, 10, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 4, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 41, "", new DateTime(2022, 4, 4, 9, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 4, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 40, "", new DateTime(2022, 4, 4, 8, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 4, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 39, "", new DateTime(2022, 4, 3, 20, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 3, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 38, "", new DateTime(2022, 4, 3, 19, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 3, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 37, "", new DateTime(2022, 4, 3, 18, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 3, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 36, "", new DateTime(2022, 4, 3, 17, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 3, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 35, "", new DateTime(2022, 4, 3, 16, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 34, "", new DateTime(2022, 4, 3, 15, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 3, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 33, "", new DateTime(2022, 4, 3, 14, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 3, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 32, "", new DateTime(2022, 4, 3, 13, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 3, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 31, "", new DateTime(2022, 4, 3, 12, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 3, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 30, "", new DateTime(2022, 4, 3, 11, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 3, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 29, "", new DateTime(2022, 4, 3, 10, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 3, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 28, "", new DateTime(2022, 4, 3, 9, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 27, "", new DateTime(2022, 4, 3, 8, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 26, "", new DateTime(2022, 4, 2, 20, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 2, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 25, "", new DateTime(2022, 4, 2, 19, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 2, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 23, "", new DateTime(2022, 4, 2, 17, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "GroupId", "Email", "End", "GroupSize", "IsAvailable", "Name", "Phone", "Start" },
                values: new object[] { 91, "", new DateTime(2022, 4, 7, 20, 59, 59, 0, DateTimeKind.Unspecified), null, true, "", "", new DateTime(2022, 4, 7, 20, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
