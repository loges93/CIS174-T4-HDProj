using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team4_FinalProject.Migrations
{
    public partial class seededmoretickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOpened",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 13, 0, 48, 13, 385, DateTimeKind.Local).AddTicks(7256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 13, 0, 29, 27, 521, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Notes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 13, 0, 48, 13, 390, DateTimeKind.Local).AddTicks(6039),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 13, 0, 29, 27, 529, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "Issue", "Status", "UserId" },
                values: new object[] { 3, "Life?", "In Progress", 5 });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "Issue", "Status", "UserId" },
                values: new object[] { 2, "Toaster?", "Completed", 5 });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "Issue", "Status", "UserId" },
                values: new object[] { 4, "Printer?", "Completed", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOpened",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 13, 0, 29, 27, 521, DateTimeKind.Local).AddTicks(2569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 13, 0, 48, 13, 385, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Notes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 13, 0, 29, 27, 529, DateTimeKind.Local).AddTicks(1245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 13, 0, 48, 13, 390, DateTimeKind.Local).AddTicks(6039));
        }
    }
}
