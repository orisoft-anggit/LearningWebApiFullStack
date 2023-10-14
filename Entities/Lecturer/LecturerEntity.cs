using Web.Api.Entities.Base;
using Web.Api.Entities.Faculty;
using Web.Api.Entities.ProgramStudy;
using Web.Api.Entities.Student;

namespace Web.Api.Entities.Lecturer
{
    public class LecturerEntity : BaseEntity
    {
        public string nidn { get; set; }

        public string firstName { get; set; }

        public string? lastName { get; set; }

        public string functionalPositionLecuture { get; set; }

        public string employmentrelationshipStatusCode { get; set; }

        public string employmentrelationshipStatusName { get; set; }

        public string highestEducation { get; set; }

        public string bachelorDegree { get; set;}

        public string emailLecturer { get; set; }

        public Guid studyProgramId { get; set; }

        public string studyProgramName { get; set; }

        public ProgramStudyEntity ProgramStudy { get; set; }

        public Guid? facultyId { get; set; }

        public string? facultyName  { get; set; }

        public FacultyEntity? Faculty { get; set; }

        public DateTimeOffset birthDate { get; set; }

        public DateTimeOffset joinDate { get; set; }

        public DateTimeOffset? endDate { get; set; }

        public string citizenshipName { get; set; }

        public string address { get; set; }

        public string lecturerStatusName { get; set; }

        public string lecturerStatusCode { get; set; }

        public string genderCode { get; set; }

        public string genderName { get; set; }

        public string religionCode { get; set; }
       
        public string religionName { get; set; }

        public string? maritalStatusCode { get; set; }
        
        public string? maritalStatusName { get; set; }

        public string? bloodTypeCode { get; set; }
        
        public string? bloodTypeName { get; set; }

        public bool isActive { get; set; }

        public List<StudentEntity> Student { get; set; }
    }
}