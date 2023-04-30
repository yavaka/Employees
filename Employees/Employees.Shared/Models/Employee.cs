using Employees.Shared.Enums;

namespace Employees.Shared.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public DateTime BirthDate { get; set; }

        public string Email { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string Zip { get; set; } = default!;
        public string City { get; set; } = default!;
        public int CountryId { get; set; }
        public Country Country { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        public bool Smoker { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public string Comment { get; set; } = default!;
        public DateTime? JoinedDate { get; set; }
        public DateTime? ExitDate { get; set; }
        
        public int JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; } = default!;

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
