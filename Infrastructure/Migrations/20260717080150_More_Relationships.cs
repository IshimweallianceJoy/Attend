using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class More_Relationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendences_Students_StudentId",
                table: "attendences");

            migrationBuilder.DropIndex(
                name: "IX_attendences_StudentId",
                table: "attendences");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "attendences");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "attendences");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "attendences");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "attendences",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "ClassStudentId",
                table: "attendences",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AttendenceStudent",
                columns: table => new
                {
                    attendencesId = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendenceStudent", x => new { x.attendencesId, x.studentId });
                    table.ForeignKey(
                        name: "FK_AttendenceStudent_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendenceStudent_attendences_attendencesId",
                        column: x => x.attendencesId,
                        principalTable: "attendences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_attendences_ClassStudentId",
                table: "attendences",
                column: "ClassStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceStudent_studentId",
                table: "AttendenceStudent",
                column: "studentId");

            migrationBuilder.AddForeignKey(
                name: "FK_attendences_classStudents_ClassStudentId",
                table: "attendences",
                column: "ClassStudentId",
                principalTable: "classStudents",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendences_classStudents_ClassStudentId",
                table: "attendences");

            migrationBuilder.DropTable(
                name: "AttendenceStudent");

            migrationBuilder.DropIndex(
                name: "IX_attendences_ClassStudentId",
                table: "attendences");

            migrationBuilder.DropColumn(
                name: "ClassStudentId",
                table: "attendences");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "attendences",
                newName: "Status");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "attendences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "attendences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "Time",
                table: "attendences",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.CreateIndex(
                name: "IX_attendences_StudentId",
                table: "attendences",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_attendences_Students_StudentId",
                table: "attendences",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
