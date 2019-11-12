using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Interfaces;
using ModelsLibrary;
namespace Logics
{
    public class ShopRepository : IRepository<Shop>
    {
        private IStorageContext _context;
        private DbSet<Shop> _dbSet;
        public ShopRepository(IStorageContext context)
        {
            _context = context;
            _dbSet = _context.Instance.Set<Shop>();
        }

        public IEnumerable<Shop> GetAll()
        {
            return _dbSet.ToList();
        }
        public Shop Get(int id)
        {
            return _dbSet.Find(id);
        }  

        public void Create(Shop item)
        {
            _dbSet.Add(item);
            _context.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            Shop item = _dbSet.Find(id);
            if (item != null)
            {
                _dbSet.Remove(item);
            }
            _context.Instance.SaveChanges();
        }

        public void Update(Shop item)
        {
            _context.Instance.Entry(item).State = EntityState.Modified;
            _context.Instance.SaveChanges();
        }
    }
}
