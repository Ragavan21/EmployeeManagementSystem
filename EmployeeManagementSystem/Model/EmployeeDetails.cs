using EmployeeManagementSystem.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Model
{
    public class EmployeeDetails : baseClass
    {
        [Key]
        public int EmployeeDetailsId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public DateOnly DOB { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        //public decimal SalaryId {get;set;}
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }
        public string Country { get; set; }
        public int EmergencyContactName { get; set; }
        public int EmergencyContactNo { get; set; }
        public Employee Employee { get; set; }



    }
}
