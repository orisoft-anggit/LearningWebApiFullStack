using System.Security.Cryptography.X509Certificates;
using Web.Api.Entities.Base;
using Web.Api.Entities.Faculty;
using Web.Api.Entities.Lecturer;
using Web.Api.Entities.Student;

namespace Web.Api.Entities.ProgramStudy
{
    public class ProgramStudyEntity : BaseEntity
    {
        public string programStudyName { get; set; }

        public string headOfTheStudyProgram { get; set; }

        public string? studyProgramSecretary { get; set; }

        public string prgramStudyAccreditation { get; set; }

        public string educationalLevel { get; set; }

        public DateTimeOffset dateOfEstablishment { get; set; }

        public string establishmentDecreeNumber { get; set; }

        public string emailProgramStudy { get; set; }
        
        public Guid facultyId { get; set; }

        public string facultyName { get; set; }

        public FacultyEntity Faculty { get; set; }
        
        public List<LecturerEntity>Lecturers { get; set; }

        public List<StudentEntity>Students { get; set; }
    }
}