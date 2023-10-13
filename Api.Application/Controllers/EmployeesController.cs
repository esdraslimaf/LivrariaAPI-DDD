using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos.Employees;
using Api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private readonly IEmployeeService _service;

        public EmployeesController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmployeeDtoCreate emp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var createResult = await _service.Post(emp);
                if (createResult != null)
                {
                    return Ok(createResult);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException erro)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, erro.Message);
            }

        }
    }
}
