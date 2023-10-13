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
        Task<EmployeeDto> Get(int id); //Buscará o livro por id
        Task<IEnumerable<EmployeeDto>> GetAll(); //Buscará todos os livros
        Task<EmployeeDtoUpdateResult> Put(EmployeeDtoUpdate Employee); //Irá atualizar o livro
        Task<bool> Delete(int id); //Deleta por id
    }
}
