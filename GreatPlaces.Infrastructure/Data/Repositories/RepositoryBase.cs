using GreatPlaces.Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GreatPlaces.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _context;

        public RepositoryBase(SqlContext sqlContext)
        {
            _context = new SqlContext();
        }

        public void Add(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Remove(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}