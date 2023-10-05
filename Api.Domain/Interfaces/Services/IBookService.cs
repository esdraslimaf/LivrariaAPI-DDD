using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services
{
    public interface IBookService
    {
        Task<BookEntity> Get(int id); //Buscará o livro por id
        Task<IEnumerable<BookEntity>> GetAll(); //Buscará todos os livros
        Task<BookEntity> Post(BookEntity book); //Irá adicionar o livro
        Task<BookEntity> Put(BookEntity book); //Irá atualizar o livro
        Task<bool> Delete(int id); //Deleta por id
    }
}
