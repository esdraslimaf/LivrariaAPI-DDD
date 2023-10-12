using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Books;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class BookService : IBookService
    {
        private IBaseRepository<BookEntity> _repo;
        private readonly IMapper _mapper;
        public BookService(IBaseRepository<BookEntity> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repo.DeleteAsync(id);
        }

        public async Task<BookDto> Get(int id)
        {
            return _mapper.Map<BookDto>(await _repo.GetByIdAsync(id));
        }

        public async Task<IEnumerable<BookDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<BookDto>>(await _repo.GetAllAsync());
        }

        public async Task<BookDtoCreateResult> Post(BookDtoCreate book)
        {
            var model = _mapper.Map<BookModel>(book);
            var entity = _mapper.Map<BookEntity>(model);
            var result = await _repo.CreateAsync(entity);
            return _mapper.Map<BookDtoCreateResult>(result);
        }

        public async Task<BookDtoUpdateResult> Put(BookDtoUpdate book)
        {
            var model = _mapper.Map<BookModel>(book);
            var entity = _mapper.Map<BookEntity>(model);
            var result = await _repo.UpdateAsync(entity);
            return _mapper.Map<BookDtoUpdateResult>(result);
            
        }
    }
}
