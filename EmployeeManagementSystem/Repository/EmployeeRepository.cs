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
            
            var EmployeeDetails = await _context.Employee.
                                    Include(e => e.Department)
                                    .ThenInclude(d => d.Designations)
                                    .ToListAsync();
                                           
             if(EmployeeDetails.Count() == 0)
            {
                return null;
            }
            else
            {
                foreach (var emp in EmployeeDetails)
                {
                    GetEmployeeDTO empDTO = new GetEmployeeDTO();
                    empDTO.EmployeeId = emp.EmployeeId;
                    empDTO.EmployeeName = emp.EmployeeName;
                    empDTO.DepartmentName = emp.Department.DepartmentName;
                    empDTO.Designation = emp.Designation.DesignationName;
                    empDTO.Email = emp.Email;
                    empDTO.contact = emp.ContactNo;
                    empDTO.ManagerId = emp.ManagerId;
                    empDTO.EmployeementStatus = emp.EmployeementStatus.ToString();

                    EmployeeListResult.Add(empDTO);

                   
                }
            }
            return EmployeeListResult;


        }
    
    public async Task<GetEmployeeFullDetailsDTO> GetEmployeeByID(int EmpId)
        {
            var result =await _context.Employee
                .Include(e => e.EmployeeDetails)
                .Include( d => d.Department)
                .ThenInclude(d => d.Designations)
                .FirstOrDefaultAsync(e => e.EmployeeId == EmpId)
                ;
            GetEmployeeFullDetailsDTO EmpResult = new GetEmployeeFullDetailsDTO();
            if (result != null)
            {
                EmpResult.EmployeeId = result.EmployeeId;
                EmpResult.EmployeeName = result.EmployeeName;
                EmpResult.Gender = result.Gender.ToString();
                EmpResult.ContactNo = result.ContactNo;
                EmpResult.Email = result.Email;
                EmpResult.JoiningDate = result.JoiningDate;
                EmpResult.IsManager = result.IsManager;
                EmpResult.ManagerId = result.ManagerId;
                EmpResult.ManagerName = "Static Value";
                EmpResult.IsActive = result.IsActive;
                EmpResult.EmployeementStatus = result.EmployeementStatus.ToString();
                EmpResult.DepartmentId = result.DepartmentId;
                EmpResult.DepartmentName = result.Department.DepartmentName;
                EmpResult.DesignationId = result.Designation.DesignationId;
                EmpResult.DateOfBirth = result.EmployeeDetails.DOB;
                EmpResult.MaritalStatus = result.EmployeeDetails.MaritalStatus.ToString();
                EmpResult.AddressLine1 = result.EmployeeDetails.AddressLine1;
                EmpResult.AddressLine2 = result.EmployeeDetails.AddressLine2;
                EmpResult.City = result.EmployeeDetails.City;
                EmpResult.State = result.EmployeeDetails.State;
                EmpResult.Pincode = result.EmployeeDetails.Pincode;
                EmpResult.Country = result.EmployeeDetails.Country;
                EmpResult.EmergencyContactName = result.EmployeeDetails.EmergencyContactName;
                EmpResult.EmergencyContactNo = result.EmployeeDetails.EmergencyContactNo;

                return EmpResult;
            }
            else
            {
                return null;
            }
        }
       
    
    }
}
