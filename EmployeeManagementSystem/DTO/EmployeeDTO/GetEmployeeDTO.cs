namespace EmployeeManagementSystem.DTO.EmployeeDTO
{
    public class GetEmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
        public string Designation { get; set; }
        //public string Role { get; set; }
        public string Email { get; set; }
        public string contact { get; set; }
        //public string ManagerName { get; set; }
        public int ManagerId { get; set; }
        public string EmployeementStatus { get; set; }
    }
}
