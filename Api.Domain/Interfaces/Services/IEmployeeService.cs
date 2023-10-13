using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Employees;

namespace Api.Domain.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<EmployeeDtoCreateResult> Post(EmployeeDtoCreate emp);
    }
}
