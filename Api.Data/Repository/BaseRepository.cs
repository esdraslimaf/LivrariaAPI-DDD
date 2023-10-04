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

            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "A entidade não pode ser nula.");
            }
            try
            {
                entity.CreateAt = DateTime.Now;
                _dbset.Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {

                throw new Exception($"Ocorreu um erro ao criar a entidade: {ex.Message}");
            }

        }

        public async Task<bool> DeleteAsync(int id)
        {

            try
            {
                var Entity = await _dbset.SingleOrDefaultAsync(u => u.Id == id);
                if (Entity == null)
                {
                    return false;
                }
                _dbset.Remove(Entity);
                await _context.SaveChangesAsync();

                return true;

            }
            catch (Exception erro)
            {

                throw new Exception($"Um erro ocorreu. Detalhes: {erro}");
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                T entidadebuscada = await _dbset.FirstOrDefaultAsync(t => t.Id == id);
                if (entidadebuscada != null)
                {
                    return entidadebuscada;
                }
                else
                {
                    throw new Exception("Nenhum item encontrado com o ID fornecido.");
                }
            }
            catch (Exception erro)
            {
                throw new Exception($"Um erro ocorreu. Detalhes: {erro}");
            }

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
