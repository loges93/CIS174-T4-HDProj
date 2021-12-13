using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team4_FinalProject.Migrations
{
    public partial class CategorytoIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Tickets",
                newName: "Issue");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOpened",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 12, 18, 33, 50, 660, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Notes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 12, 18, 33, 50, 665, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Notes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Notes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notes_UserId1",
                table: "Notes",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Users_UserId1",
                table: "Notes",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Users_UserId1",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_UserId1",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "DateOpened",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "Issue",
                table: "Tickets",
                newName: "Category");
        }
    }
}
