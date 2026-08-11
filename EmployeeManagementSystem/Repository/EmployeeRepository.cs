using EmployeeManagementSystem.DTO.EmployeeDTO;
using EmployeeManagementSystem.Enums;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<GetEmployeeDTO>> GetAllEmployee()
        {
            List<GetEmployeeDTO> EmployeeListResult = new List<GetEmployeeDTO>();
            GetEmployeeDTO empDTO = new GetEmployeeDTO();
            var EmployeeDetails = await _context.Employee.
                                    Include(e => e.Department)
                                    .ThenInclude(d => d.Designations)
                                    .ToListAsync();
                                           
            if(EmployeeDetails != null)
            {
                foreach(var emp in EmployeeDetails)
                {
                    empDTO.EmployeeId = emp.EmployeeId;
                    empDTO.EmployeeName = emp.EmployeeName;
                    empDTO.DepartmentName = emp.Department.DepartmentName;
                    empDTO.Designation = emp.Designation.DesignationName;
                    empDTO.Email = emp.Email;
                    empDTO.contact = emp.ContactNo;
                    empDTO.ManagerId = emp.ManagerId != null ? emp.ManagerId : 0;
                    empDTO.EmployeementStatus = emp.EmployeementStatus.ToString();
                }
            }

            return EmployeeListResult;
        }
    }
}
