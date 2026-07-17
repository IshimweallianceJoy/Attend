using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Updatesofentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendenceStudent");

            migrationBuilder.DropTable(
                name: "ClasssStudent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                        name: "FK_AttendenceStudent_Attendences_attendencesId",
                        column: x => x.attendencesId,
                        principalTable: "Attendences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendenceStudent_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClasssStudent",
                columns: table => new
                {
                    ClasssesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasssStudent", x => new { x.ClasssesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_ClasssStudent_Classes_ClasssesId",
                        column: x => x.ClasssesId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClasssStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendenceStudent_studentId",
                table: "AttendenceStudent",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClasssStudent_StudentsId",
                table: "ClasssStudent",
                column: "StudentsId");
        }
    }
}
