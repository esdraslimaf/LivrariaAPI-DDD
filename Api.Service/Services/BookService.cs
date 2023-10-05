using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;

namespace Api.Service.Services
{
    public class BookService : IBookService
    {
        private IBaseRepository<BookEntity> _repo;

        public BookService(IBaseRepository<BookEntity> repo)
        {
            _repo = repo;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repo.DeleteAsync(id);
        }

        public async Task<BookEntity> Get(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task<IEnumerable<BookEntity>> GetAll()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<BookEntity> Post(BookEntity book)
        {
            return await _repo.CreateAsync(book);
        }

        public async Task<BookEntity> Put(BookEntity book)
        {
            return await _repo.UpdateAsync(book);
        }
    }
}
