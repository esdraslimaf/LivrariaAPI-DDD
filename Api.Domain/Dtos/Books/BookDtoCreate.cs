using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.Books
{
    public class BookDtoCreate
    {
       public string Title { get; set; } 
       public int AuthorId { get; set; }
    }
}
