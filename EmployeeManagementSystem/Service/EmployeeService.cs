using EmployeeManagementSystem.DTO.EmployeeDTO;
using EmployeeManagementSystem.Repository;
using EmployeeManagementSystem.Repository.Interface;
using EmployeeManagementSystem.Service.Interface;

namespace EmployeeManagementSystem.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetEmployeeDTO>> GetAllEmployee()
        {
          var EmployeeListResult =await _repository.GetAllEmployee();
            if (EmployeeListResult == null)
            {
                return null;
            }
            return EmployeeListResult;

        }
        public async Task<GetEmployeeFullDetailsDTO> GetEmployeeByID(int EmpID)
        {
            var result = await _repository.GetEmployeeByID(EmpID);
            if(result == null)
            {
                return null;
            }
            return result;
        }
    }
}
