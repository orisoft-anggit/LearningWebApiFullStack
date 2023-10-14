﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.Api.Infrastucture.Context;

#nullable disable

namespace Web.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Web.Api.Entities.Employee.EmployeeEntity", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bachelorDegree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("birthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("bloodTypeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bloodTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("citizenshipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("createdAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("deletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("deletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailEmployee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeStatusCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employeeStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employmentrelationshipStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("endDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("functionalPositionEmployee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genderCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("highestEducation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("joinDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maritalStatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maritalStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("religionCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("religionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("updatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Web.Api.Entities.Faculty.FacultyEntity", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("createdAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("dateOfEstablishment")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("deletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("deletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("deputyHeadOfFacultyOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("deputyHeadOfFacultyThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("deputyHeadOfFacultyTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailFaculty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("establishmentDecreeNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("facultyAccreditation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("facultyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("headOfFaculty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numberOfLecturers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numberOfStudents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numberOfStudyPrograms")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("updatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Facultys");
                });

            modelBuilder.Entity("Web.Api.Entities.Lecturer.LecturerEntity", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bachelorDegree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("birthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("bloodTypeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bloodTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("citizenshipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("createdAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("deletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("deletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailLecturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employmentrelationshipStatusCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employmentrelationshipStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("endDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("facultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("facultyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("functionalPositionLecuture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genderCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("highestEducation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("joinDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lecturerStatusCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lecturerStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maritalStatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maritalStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nidn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("religionCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("religionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("studyProgramId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("studyProgramName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("updatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("facultyId");

                    b.HasIndex("studyProgramId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("Web.Api.Entities.ProgramStudy.ProgramStudyEntity", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("createdAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("dateOfEstablishment")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("deletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("deletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("educationalLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailProgramStudy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("establishmentDecreeNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("facultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("facultyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("headOfTheStudyProgram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prgramStudyAccreditation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("programStudyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studyProgramSecretary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("updatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("facultyId");

                    b.ToTable("ProgramStudys");
                });

            modelBuilder.Entity("Web.Api.Entities.Student.StudentEntity", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("academicSupervisorLecturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("birthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("bloodTypeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bloodTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("citizenshipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("createdAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("createdBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("deletedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("deletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("emailStudent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("facultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("facultyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genderCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("genderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("graduateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("joinDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("lecturerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("maritalStatusCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maritalStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("religionCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("religionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentIdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentStatusCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studentStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("studyProgramId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("studyProgramName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("updatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("updatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("facultyId");

                    b.HasIndex("lecturerId");

                    b.HasIndex("studyProgramId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Web.Api.Entities.Lecturer.LecturerEntity", b =>
                {
                    b.HasOne("Web.Api.Entities.Faculty.FacultyEntity", "Faculty")
                        .WithMany("Lecturers")
                        .HasForeignKey("facultyId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Web.Api.Entities.ProgramStudy.ProgramStudyEntity", "ProgramStudy")
                        .WithMany("Lecturers")
                        .HasForeignKey("studyProgramId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("ProgramStudy");
                });

            modelBuilder.Entity("Web.Api.Entities.ProgramStudy.ProgramStudyEntity", b =>
                {
                    b.HasOne("Web.Api.Entities.Faculty.FacultyEntity", "Faculty")
                        .WithMany("ProgramStudys")
                        .HasForeignKey("facultyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Web.Api.Entities.Student.StudentEntity", b =>
                {
                    b.HasOne("Web.Api.Entities.Faculty.FacultyEntity", "Faculty")
                        .WithMany("Students")
                        .HasForeignKey("facultyId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Web.Api.Entities.Lecturer.LecturerEntity", "Lecturer")
                        .WithMany("Student")
                        .HasForeignKey("lecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Web.Api.Entities.ProgramStudy.ProgramStudyEntity", "ProgramStudy")
                        .WithMany("Students")
                        .HasForeignKey("studyProgramId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("Lecturer");

                    b.Navigation("ProgramStudy");
                });

            modelBuilder.Entity("Web.Api.Entities.Faculty.FacultyEntity", b =>
                {
                    b.Navigation("Lecturers");

                    b.Navigation("ProgramStudys");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Web.Api.Entities.Lecturer.LecturerEntity", b =>
                {
                    b.Navigation("Student");
                });

            modelBuilder.Entity("Web.Api.Entities.ProgramStudy.ProgramStudyEntity", b =>
                {
                    b.Navigation("Lecturers");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
