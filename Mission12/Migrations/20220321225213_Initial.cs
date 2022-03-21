using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Booked = table.Column<bool>(nullable: false),
                    GroupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 4, false, "Afternoon", new DateTime(2022, 5, 3, 12, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 3, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 28, false, "Morning", new DateTime(2022, 5, 6, 8, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 29, false, "Mid Morning", new DateTime(2022, 5, 6, 9, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 6, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 30, false, "Late Morning", new DateTime(2022, 5, 6, 10, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 6, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 31, false, "Afternoon", new DateTime(2022, 5, 6, 12, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 6, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 32, false, "Mid Afternoon", new DateTime(2022, 5, 6, 13, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 6, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 33, false, "Late Afternoon", new DateTime(2022, 5, 6, 14, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 6, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 34, false, "Evening", new DateTime(2022, 5, 6, 17, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 6, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 35, false, "Mid Evening", new DateTime(2022, 5, 6, 18, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 6, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 27, false, "Late Evening", new DateTime(2022, 5, 5, 19, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 5, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 36, false, "Late Evening", new DateTime(2022, 5, 6, 19, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 6, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 38, false, "Mid Morning", new DateTime(2022, 5, 7, 9, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 7, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 39, false, "Late Morning", new DateTime(2022, 5, 7, 10, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 7, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 40, false, "Afternoon", new DateTime(2022, 5, 7, 12, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 7, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 41, false, "Mid Afternoon", new DateTime(2022, 5, 7, 13, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 7, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 42, false, "Late Afternoon", new DateTime(2022, 5, 7, 14, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 7, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 43, false, "Evening", new DateTime(2022, 5, 7, 17, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 7, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 44, false, "Mid Evening", new DateTime(2022, 5, 7, 18, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 7, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 45, false, "Late Evening", new DateTime(2022, 5, 7, 19, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 7, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 37, false, "Morning", new DateTime(2022, 5, 7, 8, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 7, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 25, false, "Evening", new DateTime(2022, 5, 5, 17, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 5, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 26, false, "Mid Evening", new DateTime(2022, 5, 5, 18, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 5, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 13, false, "Afternoon", new DateTime(2022, 5, 4, 12, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 4, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 7, false, "Evening", new DateTime(2022, 5, 3, 17, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 3, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 8, false, "Mid Evening", new DateTime(2022, 5, 3, 18, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 3, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 9, false, "Late Evening", new DateTime(2022, 5, 3, 19, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 3, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 10, false, "Morning", new DateTime(2022, 5, 4, 8, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 4, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 11, false, "Mid Morning", new DateTime(2022, 5, 4, 9, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 4, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 12, false, "Late Morning", new DateTime(2022, 5, 4, 10, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 4, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 24, false, "Late Afternoon", new DateTime(2022, 5, 5, 14, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 5, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 14, false, "Mid Afternoon", new DateTime(2022, 5, 4, 13, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 4, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 15, false, "Late Afternoon", new DateTime(2022, 5, 4, 14, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 4, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 16, false, "Evening", new DateTime(2022, 5, 4, 17, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 4, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 17, false, "Mid Evening", new DateTime(2022, 5, 4, 18, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 4, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 18, false, "Late Evening", new DateTime(2022, 5, 4, 19, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 4, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 19, false, "Morning", new DateTime(2022, 5, 5, 8, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 5, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 20, false, "Mid Morning", new DateTime(2022, 5, 5, 9, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 5, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 21, false, "Late Morning", new DateTime(2022, 5, 5, 10, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 22, false, "Afternoon", new DateTime(2022, 5, 5, 12, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 5, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 23, false, "Mid Afternoon", new DateTime(2022, 5, 5, 13, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 5, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 6, false, "Late Afternoon", new DateTime(2022, 5, 3, 14, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 3, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 5, false, "Mid Afternoon", new DateTime(2022, 5, 3, 13, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 5, 3, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Email", "GroupName", "GroupSize", "Phone" },
                values: new object[] { 2, "provotest@gmail.com", "Provo 6", 15, "801-555-5555" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Email", "GroupName", "GroupSize", "Phone" },
                values: new object[] { 1, "codytest@gmail.com", "Carlock", 2, "253-555-5555" });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Email", "GroupName", "GroupSize", "Phone" },
                values: new object[] { 3, "ysatest@gmail.com", "YSA 128", 3, "911-555-5555" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 1, true, "Morning", new DateTime(2022, 5, 3, 8, 45, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 5, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 2, true, "Mid Morning", new DateTime(2022, 5, 3, 9, 45, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 5, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "Booked", "Description", "EndDate", "GroupId", "StartDate" },
                values: new object[] { 3, true, "Late Morning", new DateTime(2022, 5, 3, 10, 45, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2022, 5, 3, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_GroupId",
                table: "Appointments",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
