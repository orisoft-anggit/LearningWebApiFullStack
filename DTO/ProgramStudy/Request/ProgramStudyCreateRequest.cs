using Web.Api.Helpers;

namespace Web.Api.DTO.ProgramStudy.Request
{
    public class ProgramStudyCreateRequest
    {
        public string programStudyName { get; set; }

        public string headOfTheStudyProgram { get; set; }

        public string? studyProgramSecretary { get; set; }

        public string prgramStudyAccreditation { get; set; }

        public string educationalLevel { get; set; }

        public DateTimeOffset dateOfEstablishment { get; set; }

        public string establishmentDecreeNumber { get; set; }

        public string emailProgramStudy { get; set; }

        public DropdownResponse faculty { get; set; }
    }
}