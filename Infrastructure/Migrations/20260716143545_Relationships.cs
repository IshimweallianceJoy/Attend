using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Relationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "attendences",
                newName: "ClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_attendences_ClassesId",
                table: "attendences",
                column: "ClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_attendences_StudentId",
                table: "attendences",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_attendences_Classes_ClassesId",
                table: "attendences",
                column: "ClassesId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_attendences_Students_StudentId",
                table: "attendences",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attendences_Classes_ClassesId",
                table: "attendences");

            migrationBuilder.DropForeignKey(
                name: "FK_attendences_Students_StudentId",
                table: "attendences");

            migrationBuilder.DropIndex(
                name: "IX_attendences_ClassesId",
                table: "attendences");

            migrationBuilder.DropIndex(
                name: "IX_attendences_StudentId",
                table: "attendences");

            migrationBuilder.RenameColumn(
                name: "ClassesId",
                table: "attendences",
                newName: "ClassId");
        }
    }
}
