using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Author;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;
using AutoMapper;

namespace Api.Service
{
    public class AuthorService : IAuthorService
    {

        private IBaseRepository<AuthorEntity> _repo;
        private readonly IMapper _mapper;
        public AuthorService(IBaseRepository<AuthorEntity> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
           return await _repo.DeleteAsync(id);
        }

        public async Task<AuthorDto> Get(int id)
        {
          return await _repo.GetByIdAsync(id);
        }

        public async Task<IEnumerable<AuthorDto>> GetAll()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<AuthorDtoCreateResult> Post(AuthorDtoCreate author)
        {
           return await _repo.CreateAsync(author);
        }

        public async Task<AuthorDtoUpdateResult> Put(AuthorDtoUpdate author)
        {
           return await _repo.UpdateAsync(author);
        }
    }
}
