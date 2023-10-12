using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Dtos.Books;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services
{
    public interface IBookService
    {
        Task<BookDto> Get(int id); //Buscará o livro por id
        Task<IEnumerable<BookDto>> GetAll(); //Buscará todos os livros
        Task<BookDtoCreateResult> Post(BookDtoCreate book); //Irá adicionar o livro
        Task<BookDtoUpdateResult> Put(BookDtoUpdate book); //Irá atualizar o livro
        Task<bool> Delete(int id); //Deleta por id
    }
}
