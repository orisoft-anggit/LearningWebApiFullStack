using Microsoft.EntityFrameworkCore;
using Web.Api.DTO;
using Web.Api.DTO.Faculty.Response;
using Web.Api.Entities.Faculty;
using Web.Api.Filter;
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
        public async Task<PagedResponse<FacultyDetailResponse>> GetListFaculty(PaginationFilter filter)
        {
            var facultyData = await context.Facultys.ToListAsync();
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
            var pagedData = new List<FacultyEntity>();
            var totalRecords = 0;

            if (filter?.Search != null)
            {
                pagedData = facultyData
                    .Where(e => e.facultyName.Contains(filter?.Search))
                    .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                    .Take(validFilter.PageSize)
                    .ToList();
                totalRecords = facultyData.Where(e => e.facultyName.Contains(filter?.Search)).Count();
            }

            if (filter?.Search == null)
            {
                pagedData = facultyData
                   .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                   .Take(validFilter.PageSize)
                   .ToList();
                totalRecords = await context.Facultys.CountAsync();
            }
            var pagedResponse = new PagedResponse<FacultyDetailResponse>();
                pagedResponse.Data = pagedData.Select(x => new FacultyDetailResponse()
                {
                    id = x.id,
                    facultyName = x.facultyName,
                    headOfFaculty = x.headOfFaculty,
                    deputyHeadOfFacultyOne = x.deputyHeadOfFacultyOne != null ? x.deputyHeadOfFacultyOne : null,
                    deputyHeadOfFacultyTwo = x.deputyHeadOfFacultyTwo != null ? x.deputyHeadOfFacultyTwo : null,
                    deputyHeadOfFacultyThree = x.deputyHeadOfFacultyThree != null ? x.deputyHeadOfFacultyThree : null,
                    numberOfLecturers = x.numberOfLecturers,
                    numberOfStudents = x.numberOfStudents,
                    numberOfStudyPrograms = x.numberOfStudyPrograms,
                    facultyAccreditation = x.facultyAccreditation,
                    dateOfEstablishment = x.dateOfEstablishment,
                    establishmentDecreeNumber = x.establishmentDecreeNumber,
                    emailFaculty = x.emailFaculty
                }).ToList();

            return pagedResponse;
            
        }
    }
}