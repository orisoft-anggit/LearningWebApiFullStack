using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    employeeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bachelorDegree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    functionalPositionEmployee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employmentrelationshipStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    highestEducation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailEmployee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    joinDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    endDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    citizenshipName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employeeStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employeeStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    genderCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    genderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    religionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    religionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maritalStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maritalStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bloodTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bloodTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    createdBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Facultys",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    facultyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    headOfFaculty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deputyHeadOfFacultyOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deputyHeadOfFacultyTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deputyHeadOfFacultyThree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numberOfLecturers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberOfStudents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numberOfStudyPrograms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    facultyAccreditation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateOfEstablishment = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    establishmentDecreeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailFaculty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facultys", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramStudys",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    programStudyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    headOfTheStudyProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studyProgramSecretary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prgramStudyAccreditation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    educationalLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateOfEstablishment = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    establishmentDecreeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailProgramStudy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    facultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    facultyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramStudys", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProgramStudys_Facultys_facultyId",
                        column: x => x.facultyId,
                        principalTable: "Facultys",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Lectures",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nidn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    functionalPositionLecuture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employmentrelationshipStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employmentrelationshipStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    highestEducation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bachelorDegree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailLecturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studyProgramId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    studyProgramName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    facultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    facultyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    birthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    joinDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    endDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    citizenshipName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lecturerStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lecturerStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    genderCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    genderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    religionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    religionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maritalStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maritalStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bloodTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bloodTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    createdBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectures", x => x.id);
                    table.ForeignKey(
                        name: "FK_Lectures_Facultys_facultyId",
                        column: x => x.facultyId,
                        principalTable: "Facultys",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Lectures_ProgramStudys_studyProgramId",
                        column: x => x.studyProgramId,
                        principalTable: "ProgramStudys",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    studentIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    studyProgramId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    studyProgramName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    facultyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    facultyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    birthDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    joinDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    graduateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    emailStudent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    citizenshipName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentStatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    genderCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    genderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    religionCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    religionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    maritalStatusCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maritalStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bloodTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bloodTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    createdBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    updatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    deletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.id);
                    table.ForeignKey(
                        name: "FK_Students_Facultys_facultyId",
                        column: x => x.facultyId,
                        principalTable: "Facultys",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Students_ProgramStudys_studyProgramId",
                        column: x => x.studyProgramId,
                        principalTable: "ProgramStudys",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_facultyId",
                table: "Lectures",
                column: "facultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_studyProgramId",
                table: "Lectures",
                column: "studyProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramStudys_facultyId",
                table: "ProgramStudys",
                column: "facultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_facultyId",
                table: "Students",
                column: "facultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_studyProgramId",
                table: "Students",
                column: "studyProgramId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Lectures");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ProgramStudys");

            migrationBuilder.DropTable(
                name: "Facultys");
        }
    }
}
