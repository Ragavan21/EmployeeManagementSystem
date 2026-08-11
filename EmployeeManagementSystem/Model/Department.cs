using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Model
{
    public class Department : baseClass
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }

        public ICollection<Designation> Designations { get; set; }
       public ICollection<Employee> Employee { get; set; }

    }
}
