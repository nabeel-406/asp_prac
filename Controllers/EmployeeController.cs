using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pract02.data;
using pract02.models;

namespace pract02.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmpDbContext _empDbContext;
        public EmployeeController(EmpDbContext empDbContext)
        {
            _empDbContext = empDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employee = await _empDbContext.ETbl.ToListAsync();
            return Ok(employee);
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employee)
        {
            employee.Id=Guid.NewGuid();
            await _empDbContext.ETbl.AddAsync(employee);
            await _empDbContext.SaveChangesAsync();
            return Ok(employee);
        }
    }
}