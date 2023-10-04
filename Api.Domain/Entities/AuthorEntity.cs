using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class AuthorEntity:BaseEntity
    {
        public string Name { get; set; }
        public List<BookEntity>? Books { get; set; }
    }
}
