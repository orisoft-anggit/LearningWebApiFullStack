using System.ComponentModel.DataAnnotations;

namespace Web.Api.DTO.Faculty.Request
{
    public class FacultyCreateRequest
    {
        [Required]
        public string facultyName { get; set; }

        [Required]
        public string headOfFaculty { get; set; }

        public string? deputyHeadOfFacultyOne { get; set; }

        public string? deputyHeadOfFacultyTwo { get; set; }

        public string? deputyHeadOfFacultyThree { get; set; }

        [Required]
        public string numberOfLecturers { get; set; }

        [Required]
        public string numberOfStudents { get; set; }

        [Required]
        public string numberOfStudyPrograms { get; set;}

        [Required]
        public string facultyAccreditation { get; set; }

        public DateTimeOffset dateOfEstablishment { get; set; }

        public string establishmentDecreeNumber { get; set; }

        public string emailFaculty { get; set; }
    }
}