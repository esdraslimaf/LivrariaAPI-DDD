using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Employees;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IBaseRepository<EmployeeEntity> _repo;
        private readonly IMapper _mapper;
        public EmployeeService(IBaseRepository<EmployeeEntity> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repo.DeleteAsync(id);
        }

        public async Task<EmployeeDto> Get(int id)
        {
             return _mapper.Map<EmployeeDto>(await _repo.GetByIdAsync(id));
        }

        public async Task<IEnumerable<EmployeeDto>> GetAll()
        {
             return _mapper.Map<IEnumerable<EmployeeDto>>(await _repo.GetAllAsync());
        }

        public async Task<EmployeeDtoCreateResult> Post(EmployeeDtoCreate emp)
        {
            var model = _mapper.Map<EmployeeModel>(emp);
            var entity = _mapper.Map<EmployeeEntity>(model);
            var result = await _repo.CreateAsync(entity);
            return _mapper.Map<EmployeeDtoCreateResult>(result);
        }

        public async Task<EmployeeDtoUpdateResult> Put(EmployeeDtoUpdate Employee)
        {
            var model = _mapper.Map<EmployeeModel>(Employee);
            var entity = _mapper.Map<EmployeeEntity>(model);
            var result = await _repo.UpdateAsync(entity);
            return _mapper.Map<EmployeeDtoUpdateResult>(result);
        }
    }
}
