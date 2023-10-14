using Web.Api.Entities.Base;
using Web.Api.Entities.Faculty;
using Web.Api.Entities.Lecturer;
using Web.Api.Entities.ProgramStudy;

namespace Web.Api.Entities.Student
{
    public class StudentEntity : BaseEntity
    {
        public string studentIdNumber { get; set; }

        public string firstName { get; set; }

        public string? lastName { get; set; }

        public Guid lecturerId { get; set; }

        public string academicSupervisorLecturer { get; set; }

        public LecturerEntity Lecturer { get; set; }

        public Guid studyProgramId { get; set; }

        public string studyProgramName { get; set; }

        public ProgramStudyEntity ProgramStudy { get; set; }

        public Guid? facultyId { get; set; }

        public string? facultyName  { get; set; }

        public FacultyEntity? Faculty { get; set; }

        public DateTimeOffset birthDate { get; set; }

        public DateTimeOffset joinDate { get; set; }

        public DateTimeOffset? graduateDate { get; set; }

        public string emailStudent { get; set; }

        public string citizenshipName { get; set; }

        public string address { get; set; }

        public string studentStatusName { get; set; }

        public string studentStatusCode { get; set; }

        public string genderCode { get; set; }

        public string genderName { get; set; }

        public string religionCode { get; set; }
       
        public string religionName { get; set; }

        public string? maritalStatusCode { get; set; }
        
        public string? maritalStatusName { get; set; }

        public string? bloodTypeCode { get; set; }
        
        public string? bloodTypeName { get; set; }

        public bool isActive { get; set; }
    }
}