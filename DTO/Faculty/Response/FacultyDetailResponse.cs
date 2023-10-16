namespace Web.Api.DTO.Faculty.Response
{
    public class FacultyDetailResponse
    {
        public Guid id { get; set; }

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
    }
}