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

        [HttpPost("faculty/export")]
        public async Task<FileResult> DownloadFaculty(FacultyExportRequest request)
        {
            //get all faculty 
            var facultyData = await context.Facultys.AsNoTracking().ToListAsync();

            //create an excel file, using an XLWorkbook instance
            using var workbook = new XLWorkbook();

            //create cell worksheets based on faculty data
            var worksheet = workbook.Worksheets.Add(request.entityMethod.value);

            //currentRow initiation starts from the first excel row
            var currentRow = 1;

            //Formatting the headers row
            worksheet.Row(currentRow).Height = 20.0;
            worksheet.Row(currentRow).Style.Font.Bold = true;
            //worksheet.Row(currentRow).Style.Fill.BackgroundColor = XLColor.LightGray;
            worksheet.Row(currentRow).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            //header cell
            worksheet.Cell(currentRow, 1).Value = "No";
            worksheet.Cell(currentRow, 2).Value = "Name Faculty";
            worksheet.Cell(currentRow, 3).Value = "Head Of Faculty";
            worksheet.Cell(currentRow, 4).Value = "Deputy Head Of Faculty One";
            worksheet.Cell(currentRow, 5).Value = "Deputy Head Of Faculty Two";
            worksheet.Cell(currentRow, 6).Value = "Deputy Head Of Faculty Three";
            worksheet.Cell(currentRow, 7).Value = "Number Of Lectures";
            worksheet.Cell(currentRow, 8).Value = "Number Of Students";
            worksheet.Cell(currentRow, 9).Value = "Number Of Study Programs";
            worksheet.Cell(currentRow, 10).Value = "Faculty Accreditation";
            worksheet.Cell(currentRow, 11).Value = "Date Off Establishment";
            worksheet.Cell(currentRow, 12).Value = "Establishment Decree Number";
            worksheet.Cell(currentRow, 13).Value = "Emaiil Faculty";
            //end header cell

            //loop through the faculty collection of data
            int rowNumber = 1; // Initialize row number counter
            foreach (var item in facultyData)
            {
                currentRow++;

                worksheet.Row(currentRow).Height = 20.0;
                worksheet.Row(currentRow).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                // set consecutive number for each row
                worksheet.Cell(currentRow, 1).Value = rowNumber++;

                //then access the faculty data based on the worksheet above
                worksheet.Cell(currentRow, 2).Value = item.facultyName;
                worksheet.Cell(currentRow, 3).Value = item.headOfFaculty;
                worksheet.Cell(currentRow, 4).Value = item.deputyHeadOfFacultyOne;
                worksheet.Cell(currentRow, 5).Value = item.deputyHeadOfFacultyTwo;
                worksheet.Cell(currentRow, 6).Value = item.deputyHeadOfFacultyThree;
                worksheet.Cell(currentRow, 7).Value = item.numberOfLecturers;
                worksheet.Cell(currentRow, 8).Value = item.numberOfStudents;
                worksheet.Cell(currentRow, 9).Value = item.numberOfStudyPrograms;
                worksheet.Cell(currentRow, 10).Value = item.facultyAccreditation;
                worksheet.Cell(currentRow, 11).Value = item.dateOfEstablishment.ToString("yyyy-MMM-dd");
                worksheet.Cell(currentRow, 12).Value = item.establishmentDecreeNumber;
                worksheet.Cell(currentRow, 13).Value = item.emailFaculty;
                
            }

            // save workbook files in memory stream
            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            var content = stream.ToArray();

            // and returns a file
            return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Export-Faculty.xlsx");

        }
    }
}