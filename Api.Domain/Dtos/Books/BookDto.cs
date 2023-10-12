using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Dtos.Books
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        //public AuthorEntity? Author{get;set;}
        
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
