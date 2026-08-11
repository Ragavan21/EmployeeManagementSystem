using EmployeeManagementSystem.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.Identity.Client;

namespace EmployeeManagementSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            var result = await _service.GetAllEmployee();
            if (result == null)
            {
                return NotFound("EmployeeNotFound");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetEmployeeByID(int id)
        {
            var result = await _service.GetEmployeeByID(id);
            if(result == null)
            {
                return NotFound("EmployeeNotFound");
            }
            return Ok(result);

        }

    }
}
