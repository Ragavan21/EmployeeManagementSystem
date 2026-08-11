using EmployeeManagementSystem.DTO.EmployeeDTO;

namespace EmployeeManagementSystem.Repository.Interface
{
    public interface IEmployeeRepository
    {
        public Task<List<GetEmployeeDTO>> GetAllEmployee();
    }
}
