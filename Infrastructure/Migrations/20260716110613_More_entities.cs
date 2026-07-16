using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class More_entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faculity",
                table: "Classes");

            migrationBuilder.AddColumn<int>(
                name: "EducationLevelId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FaculityId",
                table: "Classes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "attendences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attendences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "classStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_classStudents_Classes_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_classStudents_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "educationLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_educationLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "faculities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faculities", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_EducationLevelId",
                table: "Classes",
                column: "EducationLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_FaculityId",
                table: "Classes",
                column: "FaculityId");

            migrationBuilder.CreateIndex(
                name: "IX_classStudents_ClassesId",
                table: "classStudents",
                column: "ClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_classStudents_StudentsId",
                table: "classStudents",
                column: "StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_educationLevels_EducationLevelId",
                table: "Classes",
                column: "EducationLevelId",
                principalTable: "educationLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_faculities_FaculityId",
                table: "Classes",
                column: "FaculityId",
                principalTable: "faculities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_educationLevels_EducationLevelId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_faculities_FaculityId",
                table: "Classes");

            migrationBuilder.DropTable(
                name: "attendences");

            migrationBuilder.DropTable(
                name: "classStudents");

            migrationBuilder.DropTable(
                name: "educationLevels");

            migrationBuilder.DropTable(
                name: "faculities");

            migrationBuilder.DropIndex(
                name: "IX_Classes_EducationLevelId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_FaculityId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "EducationLevelId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "FaculityId",
                table: "Classes");

            migrationBuilder.AddColumn<string>(
                name: "Faculity",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
