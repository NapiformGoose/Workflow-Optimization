using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Interfaces;
using ModelsLibrary;
namespace Logics
{
    public class WorkingDayRepository : IRepository<WorkingDay>
    {
        private IStorageContext _context;
        private DbSet<WorkingDay> _dbSet;
        public WorkingDayRepository(IStorageContext context)
        {
            _context = context;
            _dbSet = _context.Instance.Set<WorkingDay>();
        }

        public IEnumerable<WorkingDay> GetAll()
        {
            IList<WorkingDay> workingDays = _dbSet
                .Include("Materials.Shop")
                .Include("Materials.MaterialType")
                .Include("Materials.WorkingDay")
                .Include("Workers.WorkerTypes")
                .Include("Services.ServiceTypes")
                .Include("Services.Shop")
                .Include("Services.WorkingDay")
                .ToList();
            return workingDays;
        }
        public WorkingDay Get(int id)
        {
            return _dbSet.Find(id);
        }  

        public void Create(WorkingDay item)
        {
            _dbSet.Add(item);
            _context.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            WorkingDay item = _dbSet.Find(id);
            if (item != null)
            {
                _dbSet.Remove(item);
            }
            _context.Instance.SaveChanges();
        }

        public void Update(WorkingDay item)
        {
            _context.Instance.Entry(item).State = EntityState.Modified;
            _context.Instance.SaveChanges();
        }
    }
}
