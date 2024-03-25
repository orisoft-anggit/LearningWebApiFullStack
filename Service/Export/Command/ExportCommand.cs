using Microsoft.AspNetCore.Mvc;
using Web.Api.DTO.Export;
using Web.Api.Service.Faculty.Command;

namespace Web.Api.Service.Export.Command
{
	public class ExportCommand
	{
        private readonly FacultyCommand facultyCommand;

        public ExportCommand(FacultyCommand facultyCommand)
		{
			this.facultyCommand = facultyCommand;
        }

		public async Task<FileResult> ExportData(ExportRequest request)
		{
			switch(request.entity.value)
			{
                case "FACULTY":
                    return await facultyCommand.ExportFaculty(request);
                default:
                    throw new ArgumentException("Invalid entity value.");
            }
        }
	}
}

