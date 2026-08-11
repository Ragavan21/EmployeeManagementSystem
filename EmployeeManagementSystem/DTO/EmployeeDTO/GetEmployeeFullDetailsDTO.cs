using EmployeeManagementSystem.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.DTO.EmployeeDTO
{
    public class GetEmployeeFullDetailsDTO
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public DateTime JoiningDate { get; set; }
        public int IsManager { get; set; }
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public int IsActive { get; set; }
        public string EmployeementStatus { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
        public int DesignationLevel { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string MaritalStatus { get; set; }
        //public decimal SalaryId {get;set;}
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }
        public string Country { get; set; }
        public int EmergencyContactName { get; set; }
        public int EmergencyContactNo { get; set; }

    }
}
