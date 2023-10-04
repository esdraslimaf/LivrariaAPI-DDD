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

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorEntity> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AuthorEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<AuthorEntity> Post(AuthorEntity author)
        {
           return await _repo.CreateAsync(author);
        }

        public Task<AuthorEntity> Put(AuthorEntity author)
        {
            throw new NotImplementedException();
        }
    }
}
