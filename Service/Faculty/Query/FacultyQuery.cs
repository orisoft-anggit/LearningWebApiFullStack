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
        public async Task<PagedResponse<FacultyDetailResponse>> GetListFaculty(PaginationFilter filter, string? sortOrder)
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

            switch (sortOrder)
            {
                case "facultyName":
                    facultyData =  facultyData.OrderBy(x => x.facultyName).ToList();
                    break;
                case "headOfFaculty":
                    facultyData = facultyData.OrderBy(x => x.headOfFaculty).ToList();
                    break;
                case "deputyHeadOfFacultyOne":
                    facultyData = facultyData.OrderBy(x => x.deputyHeadOfFacultyOne).ToList();
                    break;
                case "deputyHeadOfFacultyTwo":
                    facultyData = facultyData.OrderBy(x => x.deputyHeadOfFacultyTwo).ToList();
                    break;
                case "deputyHeadOfFacultyThree":
                    facultyData = facultyData.OrderBy(x => x.deputyHeadOfFacultyThree).ToList();
                    break;
                case "numberOfLecturers":
                    facultyData = facultyData.OrderBy(x => x.numberOfLecturers).ToList();
                    break;
                case "numberOfStudents":
                    facultyData = facultyData.OrderBy(x => x.numberOfStudents).ToList();
                    break;
                case "facultyAccreditation":
                    facultyData = facultyData.OrderBy(x => x.facultyAccreditation).ToList();
                    break;
                case "dateOfEstablishment":
                    facultyData = facultyData.OrderBy(x => x.dateOfEstablishment).ToList();
                    break;
                case "establishmentDecreeNumber":
                    facultyData = facultyData.OrderBy(x => x.establishmentDecreeNumber).ToList();
                    break;
                case "emailFaculty":
                    facultyData = facultyData.OrderBy(x => x.emailFaculty).ToList();
                    break;
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