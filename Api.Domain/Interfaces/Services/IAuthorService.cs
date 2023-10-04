using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services
{
    public interface IAuthorService
    {
        Task<AuthorEntity> Get(int id); //Buscará o autor
        Task<IEnumerable<AuthorEntity>> GetAll(); //Buscará todos os autores
        Task<AuthorEntity> Post(AuthorEntity author); //Irá adicionar o autor
        Task<AuthorEntity> Put(AuthorEntity author); //Irá atualizar o autor
        Task<bool> Delete(int id); //Deleta por id
    }
}
