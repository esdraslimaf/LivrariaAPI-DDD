using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.Employees
{
    public class EmployeeDtoUpdateResult
    {      
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
