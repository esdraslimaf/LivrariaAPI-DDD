using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public abstract class BaseEntity
    {       
        public int Id {get;set;}
        
        public DateTime? CreateAt {get;set;}    
        public DateTime? UpdateAt { get; set; } 
    }
}
