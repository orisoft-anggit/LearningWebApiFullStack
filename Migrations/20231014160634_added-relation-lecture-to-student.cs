using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Migrations
{
    /// <inheritdoc />
    public partial class addedrelationlecturetostudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "academicSupervisorLecturer",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "lecturerId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Students_lecturerId",
                table: "Students",
                column: "lecturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Lectures_lecturerId",
                table: "Students",
                column: "lecturerId",
                principalTable: "Lectures",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Lectures_lecturerId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_lecturerId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "academicSupervisorLecturer",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "lecturerId",
                table: "Students");
        }
    }
}
