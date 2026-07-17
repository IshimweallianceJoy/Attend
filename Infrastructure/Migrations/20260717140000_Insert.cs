using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Insert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendences_ClassStudents_ClassStudentId",
                table: "Attendences");

            migrationBuilder.DropIndex(
                name: "IX_Attendences_ClassStudentId",
                table: "Attendences");

            migrationBuilder.DropColumn(
                name: "ClassStudentId",
                table: "Attendences");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "Students",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateAdded",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "ClassStudentId",
                table: "Attendences",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendences_ClassStudentId",
                table: "Attendences",
                column: "ClassStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendences_ClassStudents_ClassStudentId",
                table: "Attendences",
                column: "ClassStudentId",
                principalTable: "ClassStudents",
                principalColumn: "Id");
        }
    }
}
