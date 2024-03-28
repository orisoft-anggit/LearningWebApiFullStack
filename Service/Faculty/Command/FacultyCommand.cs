using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using Web.Api.DTO;
using Web.Api.DTO.Export;
using Web.Api.DTO.Faculty.Request;
using Web.Api.DTO.Faculty.Response;
using Web.Api.Entities.Faculty;
using Web.Api.Infrastucture.Context;

namespace Web.Api.Service.Faculty.Command
{
    public class FacultyCommand
    {
        private readonly DataContext context;
        [Obsolete]
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment;

        [Obsolete]
        public FacultyCommand(DataContext context, Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            this.hostingEnvironment = hostingEnvironment;
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

        public async Task<FileResult> ExportFaculty(ExportRequest request)
        {
            var fileName = request.entity.label;
            //get all faculty 
            var facultyData = await context.Facultys.AsNoTracking().ToListAsync();

            //create an excel file, using an XLWorkbook instance
            using var workbook = new XLWorkbook();

            //create cell worksheets based on faculty data
            var worksheet = workbook.Worksheets.Add("Faculty");

            //currentRow initiation starts from the first excel row
            var currentRow = 1;

            //Formatting the headers row
            worksheet.Row(currentRow).Height = 20.0;
            worksheet.Row(currentRow).Style.Font.Bold = true;
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

            // loop through cells in rows 1 to 13 to set their background color
            for (int i = 1; i <= 13; i++)
            {
                worksheet.Cell(currentRow, i).Style.Fill.BackgroundColor = XLColor.YellowMunsell;
            }

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

            var dateNow = DateTime.Now;


            // save workbook files in memory stream
            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            var content = stream.ToArray();

            // and returns a file
            return new FileContentResult(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
            {
                FileDownloadName = $"Export -  {fileName} - {dateNow.ToString("ddd, dd MMM yyy")}"
            };

        }
    }
}