namespace EmployeeManagementSystem.Model
{
    public class LeaveType : baseClass
    {
        public int LeaveTypeId { get; set; }
        public string LeaveTypeName { get; set; }
        public int MaxDaysPerYear { get; set; }
        public int Paid { get; set; }
        public int IsActive { get; set; }
    
    }
}
