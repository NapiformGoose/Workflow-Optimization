using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Interfaces;
using ModelsLibrary;
namespace Logics
{
    public class ServiceRepository : IRepository<Service>
    {
        private IStorageContext _context;
        private DbSet<Service> _dbSet;
        public ServiceRepository(IStorageContext context)
        {
            _context = context;
            _dbSet = _context.Instance.Set<Service>();
        }

        public IEnumerable<Service> GetAll()
        {
            IList<Service> services = _dbSet
                .Include(s => s.Shop)
                .Include(m => m.ServiceTypes)
                .ToList();
            return services;
        }
        public Service Get(int id)
        {
            return _dbSet.Find(id);
        }  

        public void Create(Service item)
        {
            _dbSet.Add(item);
            _context.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            Service item = _dbSet.Find(id);
            if (item != null)
            {
                _dbSet.Remove(item);
            }
            _context.Instance.SaveChanges();
        }

        public void Update(Service item)
        {
            _context.Instance.Entry(item).State = EntityState.Modified;
            _context.Instance.SaveChanges();
        }
    }
}
