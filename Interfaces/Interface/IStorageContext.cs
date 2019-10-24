using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;

namespace Interfaces
{
    public interface IDbContext : IDisposable
    {
        DbContext Instance { get; }
    }

    public interface IStorageContext : IDbContext
    {
        DbSet<Material> Materials { get; set; }
        //DbSet<T> Services { get; set; }
        //DbSet<T> Workers { get; set; }
        //DbSet<T> WorkingDays { get; set; }
        //DbSet<T> BuildingObjects { get; set; }
    }
}
