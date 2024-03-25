using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Api.DTO;
using Web.Api.DTO.Faculty.Request;
using Web.Api.DTO.Faculty.Response;
using Web.Api.Filter;
using Web.Api.Infrastucture.Context;
using Web.Api.Service.Faculty.Command;
using Web.Api.Service.Faculty.Query;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class FacultyController : ControllerBase
    {
        private readonly FacultyCommand facultyCommand;
        private readonly FacultyQuery facultyQuery;
        private readonly DataContext context;

        public FacultyController(FacultyCommand facultyCommand, FacultyQuery facultyQuery, DataContext context)
        {
            this.facultyCommand = facultyCommand;
            this.facultyQuery = facultyQuery;
            this.context = context;
        }

        [HttpPost("faculty")]
        public async Task<FacultyCreateResponse> Create(FacultyCreateRequest request)
        {
            return await facultyCommand.CreateFaculty(request);
        }

        [HttpGet("faculty/{id}")]
        public async Task<FacultyDetailResponse> GetDetail(string id)
        {
            return await facultyQuery.GetFacultyById(id);
        }

        [HttpPut("faculty/{id}")]
        public async Task<FacultyUpdateResponse> Update(string id, FacultyUpdateRequest request)
        {
            return await facultyCommand.UpdateFaculty(id, request);
        }

        [HttpDelete("faculty/{id}")]
        public async Task<FacultyDetailResponse> Delete(string id)
        {
            return await facultyCommand.DeleteFaculty(id);
        }
                        
        [HttpGet("faculty")]
        public async Task<PagedResponse<FacultyDetailResponse>> GetAll([FromQuery] PaginationFilter filter, string? sortOrder)
        {
            return await facultyQuery.GetListFaculty(filter, sortOrder);
        }
    }
}