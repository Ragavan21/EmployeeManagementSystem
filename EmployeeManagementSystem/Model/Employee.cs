using EmployeeManagementSystem.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Model
{
    public class Employee : baseClass
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public int ContactNo { get; set; }
        public string Email { get; set; }
        public DateTime JoiningDate { get; set; }
        public int IsManager { get; set; }
        public int ManagerId { get; set; }
        public int IsActive { get; set; }
        public EmployeementStatus EmployeementStatus { get; set; }
        public EmployeeDetails EmployeeDetails { get; set; }
        public Department Department { get; set; }
        public Designation Designation { get; set; }

    }
}
