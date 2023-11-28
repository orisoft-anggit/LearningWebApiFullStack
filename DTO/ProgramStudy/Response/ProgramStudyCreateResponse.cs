using Web.Api.DTO.Base;

namespace Web.Api.DTO.ProgramStudy.Response
{
    public class ProgramStudyCreateResponse
    {
        public Guid id { get; set; }

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