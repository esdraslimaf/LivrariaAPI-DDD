using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Author;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services;
using Api.Domain.Models;
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
          return _mapper.Map<AuthorDto>(await _repo.GetByIdAsync(id));
        }

        public async Task<IEnumerable<AuthorDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<AuthorDto>>(await _repo.GetAllAsync());
        }

        public async Task<AuthorDtoCreateResult> Post(AuthorDtoCreate author)
        {
           var authorModel = _mapper.Map<AuthorModel>(author);

            var authorEntity = _mapper.Map<AuthorEntity>(authorModel);

            var result = await _repo.CreateAsync(authorEntity);

           return _mapper.Map<AuthorDtoCreateResult>(result);
        }

        public async Task<AuthorDtoUpdateResult> Put(AuthorDtoUpdate author)
        {
            var model = _mapper.Map<AuthorModel>(author);
            var entity = _mapper.Map<AuthorEntity>(model);
            var result = await _repo.UpdateAsync(entity); //Retorna o Entity já atualizado(Tanto hora de criação quanto hora de atualização, baseado no entity existente do banco de dados)
            return _mapper.Map<AuthorDtoUpdateResult>(result);
        }
    }
}
