using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class moreRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendences_Classes_ClassesId",
                table: "attendences");

            migrationBuilder.DropForeignKey(
                name: "FK_classStudents_Classes_ClassesId",
                table: "classStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_classStudents_Students_StudentsId",
                table: "classStudents");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "classStudents",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "ClassesId",
                table: "classStudents",
                newName: "ClasssId");

            migrationBuilder.RenameIndex(
                name: "IX_classStudents_StudentsId",
                table: "classStudents",
                newName: "IX_classStudents_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_classStudents_ClassesId",
                table: "classStudents",
                newName: "IX_classStudents_ClasssId");

            migrationBuilder.RenameColumn(
                name: "ClassesId",
                table: "attendences",
                newName: "ClasssId");

            migrationBuilder.RenameIndex(
                name: "IX_attendences_ClassesId",
                table: "attendences",
                newName: "IX_attendences_ClasssId");

            migrationBuilder.AddForeignKey(
                name: "FK_attendences_Classes_ClasssId",
                table: "attendences",
                column: "ClasssId",
                principalTable: "Classes",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendences_Classes_ClasssId",
                table: "attendences");

            migrationBuilder.DropForeignKey(
                name: "FK_classStudents_Classes_ClasssId",
                table: "classStudents");

            migrationBuilder.DropForeignKey(
                name: "FK_classStudents_Students_StudentId",
                table: "classStudents");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "classStudents",
                newName: "StudentsId");

            migrationBuilder.RenameColumn(
                name: "ClasssId",
                table: "classStudents",
                newName: "ClassesId");

            migrationBuilder.RenameIndex(
                name: "IX_classStudents_StudentId",
                table: "classStudents",
                newName: "IX_classStudents_StudentsId");

            migrationBuilder.RenameIndex(
                name: "IX_classStudents_ClasssId",
                table: "classStudents",
                newName: "IX_classStudents_ClassesId");

            migrationBuilder.RenameColumn(
                name: "ClasssId",
                table: "attendences",
                newName: "ClassesId");

            migrationBuilder.RenameIndex(
                name: "IX_attendences_ClasssId",
                table: "attendences",
                newName: "IX_attendences_ClassesId");

            migrationBuilder.AddForeignKey(
                name: "FK_attendences_Classes_ClassesId",
                table: "attendences",
                column: "ClassesId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_classStudents_Classes_ClassesId",
                table: "classStudents",
                column: "ClassesId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_classStudents_Students_StudentsId",
                table: "classStudents",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
