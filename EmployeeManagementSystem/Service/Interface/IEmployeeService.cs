using EmployeeManagementSystem.DTO.EmployeeDTO;

namespace EmployeeManagementSystem.Service.Interface
{
    public interface IEmployeeService
    {
        public Task<List<GetEmployeeDTO>> GetAllEmployee();
    }
}
