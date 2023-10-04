using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly MyContext _context;
        private DbSet<T> _dbset;

        public BaseRepository(MyContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            
                entity.CreateAt = DateTime.Now;
                _dbset.Add(entity);
                await _context.SaveChangesAsync();
                return entity;          
        
            
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> UpdateAsync(T entity)
        {
         try
            {
                var ExisteT = await _dbset.SingleOrDefaultAsync(u => u.Id == entity.Id);
                if (ExisteT == null)
                {
                    return null;
                }

                entity.CreateAt = ExisteT.CreateAt;
                entity.UpdateAt = DateTime.Now;
               

                _context.Entry(ExisteT).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();

            }
            catch (Exception erro)
            {
                throw new Exception($"Um erro ocorreu. Detalhes: {erro}");
            }
            return entity;
        }
    }
}
