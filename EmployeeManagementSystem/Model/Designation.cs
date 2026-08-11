using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Model
{
    public class Designation : baseClass
    {
        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
        public string DesignationCode { get; set; }
        public int Level { get; set; } // Seniority Level
        public int IsActive { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
