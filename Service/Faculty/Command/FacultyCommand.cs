using System.Linq.Expressions;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NPOI.HPSF;
using Web.Api.DTO.Faculty.Request;
using Web.Api.DTO.Faculty.Response;
using Web.Api.Entities.Faculty;
using Web.Api.Infrastucture.Context;

namespace Web.Api.Service.Faculty.Command
{
    public class FacultyCommand
    {
        private readonly DataContext context;

        public FacultyCommand(DataContext context)
        {
            this.context = context;
        }
        public async Task<FacultyCreateResponse> CreateFaculty(FacultyCreateRequest request)
        {
            var facultyEntity = new FacultyEntity();

                facultyEntity.facultyName = request.facultyName;
                facultyEntity.headOfFaculty = request.headOfFaculty;
                facultyEntity.deputyHeadOfFacultyOne = request.deputyHeadOfFacultyOne != null ? request.deputyHeadOfFacultyOne : null;
                facultyEntity.deputyHeadOfFacultyTwo = request.deputyHeadOfFacultyTwo != null ? request.deputyHeadOfFacultyTwo : null;
                facultyEntity.deputyHeadOfFacultyThree = request.deputyHeadOfFacultyThree != null ? request.deputyHeadOfFacultyThree : null;
                facultyEntity.numberOfLecturers = request.numberOfLecturers;
                facultyEntity.numberOfStudents = request.numberOfStudents;
                facultyEntity.numberOfStudyPrograms = request.numberOfStudyPrograms;
                facultyEntity.facultyAccreditation = request.facultyAccreditation;
                facultyEntity.dateOfEstablishment = request.dateOfEstablishment;
                facultyEntity.establishmentDecreeNumber = request.establishmentDecreeNumber;
                facultyEntity.emailFaculty = request.emailFaculty;
                facultyEntity.createdBy = "Anggit";
                facultyEntity.createdAt = DateTimeOffset.Now;

            var faculty = context.Facultys.Add(facultyEntity);

            await context.SaveChangesAsync();

            var response = new FacultyCreateResponse();

                response.id = Guid.NewGuid();
                response.facultyName = request.facultyName;
                response.headOfFaculty = request.headOfFaculty;
                response.deputyHeadOfFacultyOne = request.deputyHeadOfFacultyOne != null ? request.deputyHeadOfFacultyOne : null;
                response.deputyHeadOfFacultyTwo = request.deputyHeadOfFacultyTwo != null ? request.deputyHeadOfFacultyTwo : null;
                response.deputyHeadOfFacultyThree = request.deputyHeadOfFacultyThree != null ? request.deputyHeadOfFacultyThree : null;
                response.numberOfLecturers = request.numberOfLecturers;
                response.numberOfStudents = request.numberOfStudents;
                response.numberOfStudyPrograms = request.numberOfStudyPrograms;
                response.facultyAccreditation = request.facultyAccreditation;
                response.dateOfEstablishment = request.dateOfEstablishment;
                response.establishmentDecreeNumber = request.establishmentDecreeNumber;
                response.emailFaculty = request.emailFaculty;

            return response;
        }

        public async Task<FacultyUpdateResponse>UpdateFaculty(string id, FacultyUpdateRequest request)
        {
            var facultyEntity = await context.Facultys.FindAsync(Guid.Parse(id));

                facultyEntity.facultyName = request.facultyName;
                facultyEntity.headOfFaculty = request.headOfFaculty;
                facultyEntity.deputyHeadOfFacultyOne = request.deputyHeadOfFacultyOne != null ? request.deputyHeadOfFacultyOne : null;
                facultyEntity.deputyHeadOfFacultyTwo = request.deputyHeadOfFacultyTwo != null ? request.deputyHeadOfFacultyTwo : null;
                facultyEntity.deputyHeadOfFacultyThree = request.deputyHeadOfFacultyThree != null ? request.deputyHeadOfFacultyThree : null;
                facultyEntity.numberOfLecturers = request.numberOfLecturers;
                facultyEntity.numberOfStudents = request.numberOfStudents;
                facultyEntity.numberOfStudyPrograms = request.numberOfStudyPrograms;
                facultyEntity.facultyAccreditation = request.facultyAccreditation;
                facultyEntity.dateOfEstablishment = request.dateOfEstablishment;
                facultyEntity.establishmentDecreeNumber = request.establishmentDecreeNumber;
                facultyEntity.emailFaculty = request.emailFaculty;
                facultyEntity.updatedBy = "Anggit";
                facultyEntity.updatedAt = DateTimeOffset.Now;

            var faculty = context.Facultys.Update(facultyEntity);

            await context.SaveChangesAsync();

            var response = new FacultyUpdateResponse();

                response.id = Guid.NewGuid();
                response.facultyName = request.facultyName;
                response.headOfFaculty = request.headOfFaculty;
                response.deputyHeadOfFacultyOne = request.deputyHeadOfFacultyOne != null ? request.deputyHeadOfFacultyOne : null;
                response.deputyHeadOfFacultyTwo = request.deputyHeadOfFacultyTwo != null ? request.deputyHeadOfFacultyTwo : null;
                response.deputyHeadOfFacultyThree = request.deputyHeadOfFacultyThree != null ? request.deputyHeadOfFacultyThree : null;
                response.numberOfLecturers = request.numberOfLecturers;
                response.numberOfStudents = request.numberOfStudents;
                response.numberOfStudyPrograms = request.numberOfStudyPrograms;
                response.facultyAccreditation = request.facultyAccreditation;
                response.dateOfEstablishment = request.dateOfEstablishment;
                response.establishmentDecreeNumber = request.establishmentDecreeNumber;
                response.emailFaculty = request.emailFaculty;

            return response;
        }

        public async Task<FacultyDetailResponse> DeleteFaculty(string id)
        {
            var facultyEntity = await context.Facultys.FindAsync(Guid.Parse(id));

            context.Facultys.Remove(facultyEntity);

            await context.SaveChangesAsync();

            var response = new FacultyDetailResponse();
                response.id = facultyEntity.id;
                response.facultyName = facultyEntity.facultyName;
                response.headOfFaculty = facultyEntity.headOfFaculty;
                response.deputyHeadOfFacultyOne = facultyEntity.deputyHeadOfFacultyOne != null ? facultyEntity.deputyHeadOfFacultyOne : null;
                response.deputyHeadOfFacultyTwo = facultyEntity.deputyHeadOfFacultyTwo != null ? facultyEntity.deputyHeadOfFacultyTwo : null;
                response.deputyHeadOfFacultyThree = facultyEntity.deputyHeadOfFacultyThree != null ? facultyEntity.deputyHeadOfFacultyThree : null;
                response.numberOfLecturers = facultyEntity.numberOfLecturers;
                response.numberOfStudents = facultyEntity.numberOfStudents;
                response.numberOfStudyPrograms = facultyEntity.numberOfStudyPrograms;
                response.facultyAccreditation = facultyEntity.facultyAccreditation;
                response.dateOfEstablishment = facultyEntity.dateOfEstablishment;
                response.establishmentDecreeNumber = facultyEntity.establishmentDecreeNumber;
                response.emailFaculty = facultyEntity.emailFaculty;

                return response;
        }
    }
}