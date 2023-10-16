using Web.Api.DTO.Faculty.Response;
using Web.Api.Infrastucture.Context;

namespace Web.Api.Service.Faculty.Query
{
    public class FacultyQuery
    {
        private readonly DataContext context;

        public FacultyQuery(DataContext context)
        {
            this.context = context;
        }
        public async Task<FacultyDetailResponse>GetFacultyById(string id)
        {
            var facultyEntity = await context.Facultys.FindAsync(Guid.Parse(id));

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