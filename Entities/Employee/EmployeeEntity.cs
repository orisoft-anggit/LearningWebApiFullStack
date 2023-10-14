using Web.Api.Entities.Base;

namespace Web.Api.Entities.Employee
{
    public class EmployeeEntity : BaseEntity
    {
        public string employeeNumber { get; set; }

        public string firstName { get; set; }

        public string? lastName { get; set; }

        public string bachelorDegree { get; set;}

        public string functionalPositionEmployee { get; set; }

        public string employmentrelationshipStatus { get; set; }

        public string highestEducation { get; set; }

        public string emailEmployee { get; set; }

        public DateTimeOffset birthDate { get; set; }

        public DateTimeOffset joinDate { get; set; }

        public DateTimeOffset? endDate { get; set; }

        public string citizenshipName { get; set; }

        public string address { get; set; }

        public string employeeStatusName { get; set; }

        public string employeeStatusCode { get; set; }

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