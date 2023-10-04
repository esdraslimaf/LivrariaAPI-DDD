using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;

namespace Api.Service
{
    public class AuthorService : IAuthorService
    {

        private IBaseRepository<AuthorEntity> _repo;

        public AuthorService(IBaseRepository<AuthorEntity> repo)
        {
            _repo = repo;
        }

        public async Task<bool> Delete(int id)
        {
           return await _repo.DeleteAsync(id);
        }

        public async Task<AuthorEntity> Get(int id)
        {
          return await _repo.GetByIdAsync(id);
        }

        public async Task<IEnumerable<AuthorEntity>> GetAll()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<AuthorEntity> Post(AuthorEntity author)
        {
           return await _repo.CreateAsync(author);
        }

        public async Task<AuthorEntity> Put(AuthorEntity author)
        {
           return await _repo.UpdateAsync(author);
        }
    }
}
