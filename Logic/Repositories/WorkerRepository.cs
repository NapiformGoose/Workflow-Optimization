using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Interfaces;
using ModelsLibrary;
namespace Logics
{
    public class WorkerRepository : IRepository<Worker>
    {
        private IStorageContext _context;
        private DbSet<Worker> _dbSet;
        public WorkerRepository(IStorageContext context)
        {
            _context = context;
            _dbSet = _context.Instance.Set<Worker>();
        }

        public IEnumerable<Worker> GetAll()
        {
            IList<Worker> workingDays = _dbSet.ToList();
            return workingDays;
        }
        public Worker Get(int id)
        {
            return _dbSet.Find(id);
        }  

        public void Create(Worker item)
        {
            _dbSet.Add(item);
            _context.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            Worker item = _dbSet.Find(id);
            if (item != null)
            {
                _dbSet.Remove(item);
            }
            _context.Instance.SaveChanges();
        }

        public void Update(Worker item)
        {
            _context.Instance.Entry(item).State = EntityState.Modified;
            _context.Instance.SaveChanges();
        }
    }
}
