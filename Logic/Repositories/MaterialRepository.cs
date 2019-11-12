using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Interfaces;
using ModelsLibrary;
namespace Logics
{
    public class MaterialRepository : IRepository<Material>
    {
        private IStorageContext _context;
        private DbSet<Material> _dbSet;
        public MaterialRepository(IStorageContext context)
        {
            _context = context;
            _dbSet = _context.Instance.Set<Material>();
        }

        public IEnumerable<Material> GetAll()
        {
            IList<Material> materials = _dbSet
                .Include(s => s.Shop)
                .Include(m => m.MaterialType)
                .Include(w => w.WorkingDay)
                .ToList();
            return materials;
        }
        public Material Get(int id)
        {
            return _dbSet.Find(id);
        }  

        public void Create(Material item)
        {
            _dbSet.Add(item);
            _context.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            Material item = _dbSet.Find(id);
            if (item != null)
            {
                _dbSet.Remove(item);
            }
            _context.Instance.SaveChanges();
        }

        public void Update(Material item)
        {
            _context.Instance.Entry(item).State = EntityState.Modified;
            _context.Instance.SaveChanges();
        }
    }
}
