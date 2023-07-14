using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Interface;

namespace Repository.Repository
{
    public class BaseRepository<T>: IBaseRepository<T> where T : BaseDomain
    {
        protected readonly BDContext _context;
        public BaseRepository(BDContext context)
        {
            _context = context;
        }
        public async Task<T> Create(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task Delete(int id)
        {
            var obj = await _context.Set<T>().FindAsync(id);
            if (obj != null)
            {
                _context.Set<T>().Remove(obj);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();

        }

        public async Task<T> GetById(int id)
        {
            var obj = await _context.Set<T>().FindAsync(id);
            return obj;
        }

        public async Task<T> Update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
