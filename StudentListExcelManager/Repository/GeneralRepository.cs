using Microsoft.EntityFrameworkCore;
using StudentListExcelManager.IRepository;
using StudentListExcelManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentListExcelManager.Repository
{
    public class GeneralRepository<T> : IGeneralRepository<T> where T : class
    {
        protected ApplicationDbContext _context;
        public GeneralRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _context.Set<T>().AddRangeAsync(entities);
            return entities;
        }

        public async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public async Task DeleteRangeAsyn(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);

        }
        public async Task<IQueryable<T>> GetAll()
        {
            var entities = await _context.Set<T>().ToListAsync();
            return entities.AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> Update(T entity)
        {
            var entry = _context.Set<T>().Update(entity);
            return entry.Entity;
        }
        public async Task<IQueryable<T>> FindAllByForeignKeyAsync<TProperty>(Expression<Func<T, TProperty>> foreignKeySelector, TProperty foreignKey)
        {
            var parameter = foreignKeySelector.Parameters.Single();
            var body = Expression.Equal(foreignKeySelector.Body, Expression.Constant(foreignKey));

            var predicate = Expression.Lambda<Func<T, bool>>(body, parameter);

            var entities = await _context.Set<T>().Where(predicate).AsQueryable().ToListAsync();
            return entities.AsQueryable();
        }

        public async Task<IQueryable<T>> FindWithIncludeIQueryableAsync(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> entitie = _context.Set<T>();
            if (includes != null)
            {
                entitie = includes.Aggregate(entitie, (current, include) => current.Include(include));
            }
            return entitie;
        }
        public async Task<IEnumerable<T>> FindWithIncludeIEnumerableAsync(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> entities = _context.Set<T>();

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    entities = entities.Include(include);
                }
            }

            return await entities.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetEntityByPropertyAsync(Func<T, bool> predicate)
        {
            var entities = _context.Set<T>().Where(predicate).ToList();
            return entities;
        }
        public async Task<bool> UpdateRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                _context.Set<T>().UpdateRange(entities);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
