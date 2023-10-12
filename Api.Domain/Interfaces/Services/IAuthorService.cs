using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Author;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services
{
    public interface IAuthorService
    {
        Task<AuthorDto> Get(int id); //Buscará o autor
        Task<IEnumerable<AuthorDto>> GetAll(); //Buscará todos os autores
        Task<AuthorDtoCreateResult> Post(AuthorDtoCreate author); //Irá adicionar o autor
        Task<AuthorDtoUpdateResult> Put(AuthorDtoUpdate author); //Irá atualizar o autor
        Task<bool> Delete(int id); //Deleta por id
    }
}
