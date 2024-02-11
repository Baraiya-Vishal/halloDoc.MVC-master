using DataAccess.data;
using Microsoft.EntityFrameworkCore;
using Services.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly HallodocdbContext _context;
        internal DbSet<T> dbSet;


        public Repository(HallodocdbContext context)
        {
            _context = context;
            this.dbSet = _context.Set<T>();
        }


        public void Add(T entiy)
        {
            dbSet.Add(entiy);
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.FirstOrDefault();

        }

        public void Remove(T entiy)
        {
            dbSet.Remove(entiy);
        }

        public void RemoveRange(IEnumerable<T> entiy)
        {
            dbSet.RemoveRange(entiy);
        }
    }

}
