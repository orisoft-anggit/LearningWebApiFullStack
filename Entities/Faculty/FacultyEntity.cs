using Web.Api.Entities.Base;
using Web.Api.Entities.Lecturer;
using Web.Api.Entities.ProgramStudy;
using Web.Api.Entities.Student;

namespace Web.Api.Entities.Faculty
{
    public class FacultyEntity : BaseEntity
    {
        public string facultyName { get; set; }

        public string headOfFaculty { get; set; }

        public string? deputyHeadOfFacultyOne { get; set; }

        public string? deputyHeadOfFacultyTwo { get; set; }

        public string? deputyHeadOfFacultyThree { get; set; }

        public string numberOfLecturers { get; set; }

        public string numberOfStudents { get; set; }

        public string numberOfStudyPrograms { get; set;}

        public string facultyAccreditation { get; set; }

        public DateTimeOffset dateOfEstablishment { get; set; }

        public string establishmentDecreeNumber { get; set; }

        public string emailFaculty { get; set; }

        public List<ProgramStudyEntity> ProgramStudys { get; set; }

        public List<LecturerEntity>Lecturers { get; set; }

        public List<StudentEntity>Students { get; set; }
    }
}