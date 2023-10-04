using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class BookEntity:BaseEntity
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public AuthorEntity? Author{get;set;}
    }
}
