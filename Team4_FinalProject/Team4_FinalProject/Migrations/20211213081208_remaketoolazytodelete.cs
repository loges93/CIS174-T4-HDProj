using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team4_FinalProject.Migrations
{
    public partial class remaketoolazytodelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOpened",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 13, 2, 12, 8, 7, DateTimeKind.Local).AddTicks(570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 13, 2, 6, 39, 92, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Notes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 13, 2, 12, 8, 11, DateTimeKind.Local).AddTicks(5324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 13, 2, 6, 39, 97, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "NoteId", "Content", "TicketId" },
                values: new object[,]
                {
                    { 1, "Fixed the... whatever it is.", 4 },
                    { 2, "Fixed the... whatever it is.", 2 },
                    { 3, "Fixed the... whatever it is.", 4 },
                    { 4, "Fixed the... whatever it is.", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Notes",
                keyColumn: "NoteId",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOpened",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 13, 2, 6, 39, 92, DateTimeKind.Local).AddTicks(797),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 13, 2, 12, 8, 7, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Notes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 13, 2, 6, 39, 97, DateTimeKind.Local).AddTicks(6022),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 13, 2, 12, 8, 11, DateTimeKind.Local).AddTicks(5324));
        }
    }
}
