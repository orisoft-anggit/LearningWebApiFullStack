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

        // public async Task<FileResult> CreateExcel()
        // {

        //     //get data all on faculty
        //     var facultyData = await context.Facultys.ToListAsync();
        //     foreach (var item in facultyData)
        //     {
        //         facultyData.Add(new FacultyEntity()
        //         {
        //             facultyName = item.facultyName,
        //             headOfFaculty = item.headOfFaculty,
        //             deputyHeadOfFacultyOne = item.deputyHeadOfFacultyOne,
        //             deputyHeadOfFacultyTwo = item.deputyHeadOfFacultyTwo,
        //             deputyHeadOfFacultyThree = item.deputyHeadOfFacultyThree,
        //             numberOfLecturers = item.numberOfLecturers,
        //             numberOfStudents = item.numberOfStudents,
        //             numberOfStudyPrograms = item.numberOfStudyPrograms,
        //             facultyAccreditation = item.facultyAccreditation,
        //             dateOfEstablishment = item.dateOfEstablishment,
        //             establishmentDecreeNumber = item.establishmentDecreeNumber,
        //             emailFaculty = item.emailFaculty
        //         });
        //     }
        //     //ccreate file excel
        //     HSSFWorkbook workbook = new HSSFWorkbook();

        //     //the sheet name is going to be Faculty
        //     HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet("Faculty");
        //     HSSFFont font = (HSSFFont)workbook.CreateFont();

        //     //cell style
        //     var Company = workbook.CreateCellStyle();
        //     Company.Alignment = (NPOI.SS.UserModel.HorizontalAlignment)GrapeCity.Documents.Excel.HorizontalAlignment.Left;
        //     var CompanyFont = workbook.CreateFont();
        //     CompanyFont.FontName = "Arial";
        //     CompanyFont.Color = HSSFColor.Blue.Index;
        //     CompanyFont.Boldweight = (short)FontBoldWeight.Bold;
        //     CompanyFont.FontHeightInPoints = ((short)16);
        //     Company.SetFont(CompanyFont);

        //     //header style
        //     var Header = workbook.CreateCellStyle();
        //     Header.Alignment = (NPOI.SS.UserModel.HorizontalAlignment)GrapeCity.Documents.Excel.HorizontalAlignment.Center;
        //     Header.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.LightBlue.Index;
        //     Header.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.LightBlue.Index;
        //     Header.FillPattern = FillPattern.SolidForeground;
        //     var HeaderFont = workbook.CreateFont();
        //     HeaderFont.FontName = "Arial";
        //     HeaderFont.Boldweight = (short)FontBoldWeight.Bold;
        //     HeaderFont.Color = HSSFColor.White.Index;
        //     HeaderFont.FontHeightInPoints = ((short)10);
        //     Header.SetFont(HeaderFont);
        //     Header.BorderLeft = BorderStyle.Thin;
        //     Header.BorderTop = BorderStyle.Thin;
        //     Header.BorderRight = BorderStyle.Thin;
        //     Header.BorderBottom = BorderStyle.Thin;

        //     var NumData = workbook.CreateCellStyle();
        //     var formatId = HSSFDataFormat.GetBuiltinFormat("##0.00");
        //     if (formatId == -1)
        //     {
        //         var newDataFormat = workbook.CreateDataFormat();
        //         NumData.DataFormat = newDataFormat.GetFormat("##0.00");
        //     }
        //     else
        //     NumData.DataFormat = formatId;

        //     //data cell style
        //     var Data = workbook.CreateCellStyle();
        //     Data.Alignment = (NPOI.SS.UserModel.HorizontalAlignment)GrapeCity.Documents.Excel.HorizontalAlignment.Center;
        //     var DataFont = workbook.CreateFont();
        //     DataFont.FontName = "Arial";
        //     DataFont.FontHeightInPoints = ((short)9);
        //     Data.SetFont(DataFont);
        //     Data.BorderLeft = BorderStyle.Thin;
        //     Data.BorderTop = BorderStyle.Thin;
        //     Data.BorderRight = BorderStyle.Thin;
        //     Data.BorderBottom = BorderStyle.Thin;

        //     //link data cell style
        //     var linkData = workbook.CreateCellStyle();
        //     linkData.Alignment = (NPOI.SS.UserModel.HorizontalAlignment)GrapeCity.Documents.Excel.HorizontalAlignment.Center;
        //     var linkDataFont = workbook.CreateFont();
        //     linkDataFont.FontName = "Arial";
        //     linkDataFont.Color = HSSFColor.Blue.Index;
        //     linkDataFont.FontHeightInPoints = ((short)9);
        //     linkDataFont.Underline = FontUnderlineType.Single;
        //     linkDataFont.Color = HSSFColor.Blue.Index;
        //     linkData.SetFont(linkDataFont);
        //     linkData.BorderLeft = BorderStyle.Thin;
        //     linkData.BorderTop = BorderStyle.Thin;
        //     linkData.BorderRight = BorderStyle.Thin;
        //     linkData.BorderBottom = BorderStyle.Thin;

        //     int rowIndex = 2; //rowIndex 2 means 3rd Row
        //     var row = sheet.CreateRow(rowIndex);
        //     var cell = row.CreateCell(4);
        //     cell.SetCellValue("Dot Net Tutorials Online Training");
        //     cell.CellStyle = Company;
        //     sheet.AddMergedRegion(new CellRangeAddress(4, 4, 4, 14));

        //     // Set Row index for Header
        //     rowIndex = 7; //rowIndex 7 means 8th Row which is going to be our Header in Excel Sheet
        //     var SR_NO = 0; //We want a unique Serial Number for Each Row in the Excel Sheet

        //     //Excel Data Headers
        //     var cellheaderindex = 0;

        //     var excelheaderrow = sheet.CreateRow(rowIndex);
        //     var excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
        //     excelheadercell.SetCellValue("SR NO");
        //     excelheadercell.CellStyle = Header;

        //     cellheaderindex = cellheaderindex + 1;
        //     excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
        //     excelheadercell.SetCellValue("facultyName");
        //     excelheadercell.CellStyle = Header;

        //     cellheaderindex = cellheaderindex + 1;
        //     excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
        //     excelheadercell.SetCellValue("headOfFaculty");
        //     excelheadercell.CellStyle = Header;

        //     cellheaderindex = cellheaderindex + 1;
        //     excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
        //     excelheadercell.SetCellValue("deputyHeadOfFacultyOne");
        //     excelheadercell.CellStyle = Header;

        //     cellheaderindex = cellheaderindex + 1;
        //     excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
        //     excelheadercell.SetCellValue("deputyHeadOfFacultyTwo");
        //     excelheadercell.CellStyle = Header;

        //     cellheaderindex = cellheaderindex + 1;
        //     excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
        //     excelheadercell.SetCellValue("deputyHeadOfFacultyThree");
        //     excelheadercell.CellStyle = Header;

        //     cellheaderindex = cellheaderindex + 1;
        //     excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
        //     excelheadercell.SetCellValue("numberOfLecturers");
        //     excelheadercell.CellStyle = Header;

        //     cellheaderindex = cellheaderindex + 1;
        //     excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
        //     excelheadercell.SetCellValue("numberOfStudents");
        //     excelheadercell.CellStyle = Header;

        //     cellheaderindex = cellheaderindex + 1;
        //     excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
        //     excelheadercell.SetCellValue("numberOfStudyPrograms");
        //     excelheadercell.CellStyle = Header;

        //     cellheaderindex = cellheaderindex + 1;
        //     excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
        //     excelheadercell.SetCellValue("facultyAccreditation");
        //     excelheadercell.CellStyle = Header;

        //     cellheaderindex = cellheaderindex + 1;
        //     excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
        //     excelheadercell.SetCellValue("dateOfEstablishment");
        //     excelheadercell.CellStyle = Header;

        //     cellheaderindex = cellheaderindex + 1;
        //     excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
        //     excelheadercell.SetCellValue("establishmentDecreeNumber");
        //     excelheadercell.CellStyle = Header;

        //     cellheaderindex = cellheaderindex + 1;
        //     excelheadercell = excelheaderrow.CreateCell(cellheaderindex);
        //     excelheadercell.SetCellValue("emailFaculty");
        //     excelheadercell.CellStyle = Header;

        //     //excel data faculty
        //     foreach (var itemEmployee in facultyData)
        //     {
        //         rowIndex = rowIndex + 1; //This will be the row number in the Excel Sheet
        //         SR_NO = SR_NO + 1; //Unique Serial Number
        //         var cellindex = 0; //Cell Number starting from 0

        //         //Create the New Row
        //         var gridrow = sheet.CreateRow(rowIndex);
        //         //Create the first Cell in the new Row
        //         var gridcell = gridrow.CreateCell(cellindex);
        //         //Add value to the Cell 
        //         gridcell.SetCellValue(SR_NO);
        //         //Apply appropriate CSS Styles
        //         gridcell.CellStyle = Data;

        //         //Increse the Cell Index by 1 to create the next cell in the Row
        //         cellindex = cellindex + 1;
        //         //Create the new cell
        //         gridcell = gridrow.CreateCell(cellindex);
        //         //Add value to the Cell
        //         gridcell.SetCellValue(itemEmployee.facultyName);
        //         //Apply appropriate CSS Styles
        //         gridcell.CellStyle = Data;

        //         //The Process will continue till the last cell in the Row
        //         cellindex = cellindex + 1;
        //         gridcell = gridrow.CreateCell(cellindex);
        //         gridcell.SetCellValue(itemEmployee.headOfFaculty);
        //         gridcell.CellStyle = Data;

        //         cellindex = cellindex + 1;
        //         gridcell = gridrow.CreateCell(cellindex);
        //         gridcell.SetCellValue(itemEmployee.deputyHeadOfFacultyOne);
        //         gridcell.CellStyle = Data;

        //         cellindex = cellindex + 1;
        //         gridcell = gridrow.CreateCell(cellindex);
        //         gridcell.SetCellValue(itemEmployee.deputyHeadOfFacultyTwo);
        //         gridcell.CellStyle = Data;
                
        //         cellindex = cellindex + 1;
        //         gridcell = gridrow.CreateCell(cellindex);
        //         gridcell.SetCellValue(itemEmployee.deputyHeadOfFacultyThree);
        //         gridcell.CellStyle = Data;
                
        //         cellindex = cellindex + 1;
        //         gridcell = gridrow.CreateCell(cellindex);
        //         gridcell.SetCellValue(itemEmployee.numberOfLecturers);
        //         gridcell.CellStyle = Data;

        //         cellindex = cellindex + 1;
        //         gridcell = gridrow.CreateCell(cellindex);
        //         gridcell.SetCellValue(itemEmployee.numberOfStudents);
        //         gridcell.CellStyle = Data;

        //         cellindex = cellindex + 1;
        //         gridcell = gridrow.CreateCell(cellindex);
        //         gridcell.SetCellValue(itemEmployee.numberOfStudyPrograms);
        //         gridcell.CellStyle = Data;

        //         cellindex = cellindex + 1;
        //         gridcell = gridrow.CreateCell(cellindex);
        //         gridcell.SetCellValue(itemEmployee.facultyAccreditation);
        //         gridcell.CellStyle = Data;

        //         cellindex = cellindex + 1;
        //         gridcell = gridrow.CreateCell(cellindex);
        //         gridcell.SetCellValue(itemEmployee.establishmentDecreeNumber);
        //         gridcell.CellStyle = Data;

        //         cellindex = cellindex + 1;
        //         gridcell = gridrow.CreateCell(cellindex);
        //         gridcell.SetCellValue(itemEmployee.emailFaculty);
        //         gridcell.CellStyle = Data;


        //     }

        // }
        // {
        //     var facultys = await context.Facultys.ToListAsync();
        //     var workbook = new XSSFWorkbook();
        //     var sheet = workbook.CreateSheet("Sheet1");
        //     var rowHeader = sheet.CreateRow(0);

        //     var properties = typeof(FacultyEntity).GetProperties();
            
        //     //header
        //     var font = workbook.CreateFont();
        //     font.IsBold = true;
        //     var style = workbook.CreateCellStyle();
        //     style.SetFont(font);

        //     var colIndex = 0;

        //     foreach (var item in properties)
        //     {
        //         var cell = rowHeader.CreateCell(colIndex);
        //         cell.SetCellValue(item.Name);
        //         cell.CellStyle = style;
        //         colIndex++;
        //     }
        //     //end header
        // }
    }
}