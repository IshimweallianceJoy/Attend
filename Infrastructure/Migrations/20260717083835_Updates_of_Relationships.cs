using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Updates_of_Relationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendences_Classes_ClasssId",
                table: "attendences");

            migrationBuilder.DropForeignKey(
                name: "FK_attendences_classStudents_ClassStudentId",
                table: "attendences");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceStudent_attendences_attendencesId",
                table: "AttendenceStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_educationLevels_EducationLevelId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_faculities_FaculityId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_classStudents_Classes_ClasssId",
                table: "classStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_classStudents_Students_StudentId",
                table: "classStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_studentAttendences_Students_StudentId",
                table: "studentAttendences");

            migrationBuilder.DropForeignKey(
                name: "FK_studentAttendences_attendences_AttendenceId",
                table: "studentAttendences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_studentAttendences",
                table: "studentAttendences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_faculities",
                table: "faculities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_educationLevels",
                table: "educationLevels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_classStudents",
                table: "classStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_attendences",
                table: "attendences");

            migrationBuilder.RenameTable(
                name: "studentAttendences",
                newName: "StudentAttendences");

            migrationBuilder.RenameTable(
                name: "faculities",
                newName: "Faculities");

            migrationBuilder.RenameTable(
                name: "educationLevels",
                newName: "EducationLevels");

            migrationBuilder.RenameTable(
                name: "classStudents",
                newName: "ClassStudents");

            migrationBuilder.RenameTable(
                name: "attendences",
                newName: "Attendences");

            migrationBuilder.RenameIndex(
                name: "IX_studentAttendences_StudentId",
                table: "StudentAttendences",
                newName: "IX_StudentAttendences_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_studentAttendences_AttendenceId",
                table: "StudentAttendences",
                newName: "IX_StudentAttendences_AttendenceId");

            migrationBuilder.RenameIndex(
                name: "IX_classStudents_StudentId",
                table: "ClassStudents",
                newName: "IX_ClassStudents_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_classStudents_ClasssId",
                table: "ClassStudents",
                newName: "IX_ClassStudents_ClasssId");

            migrationBuilder.RenameIndex(
                name: "IX_attendences_ClassStudentId",
                table: "Attendences",
                newName: "IX_Attendences_ClassStudentId");

            migrationBuilder.RenameIndex(
                name: "IX_attendences_ClasssId",
                table: "Attendences",
                newName: "IX_Attendences_ClasssId");

            migrationBuilder.AddColumn<int>(
                name: "ClasssId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentAttendences",
                table: "StudentAttendences",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Faculities",
                table: "Faculities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationLevels",
                table: "EducationLevels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassStudents",
                table: "ClassStudents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendences",
                table: "Attendences",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClasssId",
                table: "Students",
                column: "ClasssId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentId",
                table: "Students",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendences_ClassStudents_ClassStudentId",
                table: "Attendences",
                column: "ClassStudentId",
                principalTable: "ClassStudents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendences_Classes_ClasssId",
                table: "Attendences",
                column: "ClasssId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendenceStudent_Attendences_attendencesId",
                table: "AttendenceStudent",
                column: "attendencesId",
                principalTable: "Attendences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_EducationLevels_EducationLevelId",
                table: "Classes",
                column: "EducationLevelId",
                principalTable: "EducationLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Faculities_FaculityId",
                table: "Classes",
                column: "FaculityId",
                principalTable: "Faculities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStudents_Classes_ClasssId",
                table: "ClassStudents",
                column: "ClasssId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassStudents_Students_StudentId",
                table: "ClassStudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAttendences_Attendences_AttendenceId",
                table: "StudentAttendences",
                column: "AttendenceId",
                principalTable: "Attendences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAttendences_Students_StudentId",
                table: "StudentAttendences",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClasssId",
                table: "Students",
                column: "ClasssId",
                principalTable: "Classes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Students_StudentId",
                table: "Students",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendences_ClassStudents_ClassStudentId",
                table: "Attendences");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendences_Classes_ClasssId",
                table: "Attendences");

            migrationBuilder.DropForeignKey(
                name: "FK_AttendenceStudent_Attendences_attendencesId",
                table: "AttendenceStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_EducationLevels_EducationLevelId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Faculities_FaculityId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassStudents_Classes_ClasssId",
                table: "ClassStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassStudents_Students_StudentId",
                table: "ClassStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAttendences_Attendences_AttendenceId",
                table: "StudentAttendences");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAttendences_Students_StudentId",
                table: "StudentAttendences");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClasssId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Students_StudentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClasssId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentAttendences",
                table: "StudentAttendences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Faculities",
                table: "Faculities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationLevels",
                table: "EducationLevels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassStudents",
                table: "ClassStudents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendences",
                table: "Attendences");

            migrationBuilder.DropColumn(
                name: "ClasssId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "StudentAttendences",
                newName: "studentAttendences");

            migrationBuilder.RenameTable(
                name: "Faculities",
                newName: "faculities");

            migrationBuilder.RenameTable(
                name: "EducationLevels",
                newName: "educationLevels");

            migrationBuilder.RenameTable(
                name: "ClassStudents",
                newName: "classStudents");

            migrationBuilder.RenameTable(
                name: "Attendences",
                newName: "attendences");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAttendences_StudentId",
                table: "studentAttendences",
                newName: "IX_studentAttendences_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAttendences_AttendenceId",
                table: "studentAttendences",
                newName: "IX_studentAttendences_AttendenceId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassStudents_StudentId",
                table: "classStudents",
                newName: "IX_classStudents_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassStudents_ClasssId",
                table: "classStudents",
                newName: "IX_classStudents_ClasssId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendences_ClassStudentId",
                table: "attendences",
                newName: "IX_attendences_ClassStudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Attendences_ClasssId",
                table: "attendences",
                newName: "IX_attendences_ClasssId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentAttendences",
                table: "studentAttendences",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_faculities",
                table: "faculities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_educationLevels",
                table: "educationLevels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_classStudents",
                table: "classStudents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_attendences",
                table: "attendences",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_attendences_Classes_ClasssId",
                table: "attendences",
                column: "ClasssId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_attendences_classStudents_ClassStudentId",
                table: "attendences",
                column: "ClassStudentId",
                principalTable: "classStudents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendenceStudent_attendences_attendencesId",
                table: "AttendenceStudent",
                column: "attendencesId",
                principalTable: "attendences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_classStudents_Classes_ClasssId",
                table: "classStudents",
                column: "ClasssId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_classStudents_Students_StudentId",
                table: "classStudents",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_studentAttendences_Students_StudentId",
                table: "studentAttendences",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_studentAttendences_attendences_AttendenceId",
                table: "studentAttendences",
                column: "AttendenceId",
                principalTable: "attendences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
