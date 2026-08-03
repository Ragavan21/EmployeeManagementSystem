using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Model
{
    public class Department : baseClass
    {
        public int DepartmentID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("Designation")]
        public int DesignationId { get; set; }

        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }

        public ICollection<Designation> Designations { get; set; }
       public ICollection<Employee> Employee { get; set; }

    }
}
