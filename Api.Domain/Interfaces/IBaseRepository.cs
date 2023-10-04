using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces
{
    public interface IBaseRepository<T> where T:BaseEntity
    {
        
        Task<T> CreateAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
        
    }
}
