using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.Author
{
    public class AuthorDtoCreateResult // Usado para retornar o resultado de uma operação de criação
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
